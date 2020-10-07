using ITIExamPlus.Constants;
using ITIExamPlus.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITIExamPlus.Core
{
    public class DataLayer
    {
        public static Student Login(string userName, string password)
        {
            Student student = new Student();
            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedures.Login;
                cmd.Parameters.AddWithValue("RegNumber", userName);
                cmd.Parameters.AddWithValue("Password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                student.ID = Convert.ToInt32(reader["Id"]);
                student.Name = reader["Name"].ToString();
                student.Password = reader["Password"].ToString();
                student.RegNumber = reader["RegNumber"].ToString();
                student.Trade = reader["Trade"].ToString();
                student.Shift = reader["Shift"].ToString();
                conn.Close();
            }
            catch (Exception)
            {
                student = null;
            }

            return student;

        }

        public static List<Question> GetAllQuestions()
        {
            Question question;//= new Question();
            List<Question> questions = new List<Question>();

            SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedures.GetQuestions;
            //cmd.Parameters.AddWithValue("RegNumber", userName);
            //cmd.Parameters.AddWithValue("Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                question = new Question();
                question.ID = Convert.ToInt32(reader["Id"]);
                question.QuestionText = reader["Question"].ToString();
                question.OptionA = reader["OptionA"].ToString();
                question.OptionB = reader["OptionB"].ToString();
                question.OptionC = reader["OptionC"].ToString();
                question.OptionD = reader["OptionD"].ToString();
                question.Answer = Convert.ToInt32(reader["Answer"]);
                questions.Add(question);
            }
            List<Question> questionsShfile = new List<Question>();


            while (questions.Count > 0)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                int randomNumber = random.Next(0, questions.Count);
                Thread.Sleep(10);
                questionsShfile.Add(questions[randomNumber]);
                questions.RemoveAt(randomNumber);
            }

            conn.Close();


            return questionsShfile;

        }

        public static List<Result> GetResults()
        {
            Result result;//= new Question();
            List<Result> results = new List<Result>();

            SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedures.GetResult;
            //cmd.Parameters.AddWithValue("RegNumber", userName);
            //cmd.Parameters.AddWithValue("Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = new Result();
                result.Student = new Student();
                result.ID = Convert.ToInt32(reader["Id"]);
                //result.StudentID =Convert.ToInt32( reader["StudentId"]);
                result.Mark = Convert.ToInt32(reader["Mark"]);
                result.ExamName = reader["ExamName"].ToString();
                result.Remarks = reader["Remarks"].ToString();
                result.ExamDate = reader["ExamDate"].ToString();
                result.TotalTime = reader["TotalTime"].ToString();
                result.Skipped = Convert.ToInt32(reader["Skipped"]);
                result.Wrong = Convert.ToInt32(reader["Wrong"]);
                result.TotalQuestions = Convert.ToInt32(reader["TotalQuestions"]);

                result.Student.Name = reader["Name"].ToString();
                result.Student.RegNumber = reader["RegNumber"].ToString();
                result.Student.Trade = reader["Trade"].ToString();
                result.Student.Shift = reader["Shift"].ToString();
                results.Add(result);
            }
            conn.Close();
            return results;
        }

        public static List<Student> GetUsers()
        {
            Student student;
            List<Student> students = new List<Student>();

            SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedures.GetUsers;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                student = new Student();
                student.ID = Convert.ToInt32(reader["Id"]);
                student.Name = reader["Name"].ToString();
                student.RegNumber = reader["RegNumber"].ToString();
                student.Trade = reader["Trade"].ToString();
                student.Shift = reader["Shift"].ToString();
                students.Add(student);
            }
            conn.Close();
            return students;
        }

        public static bool SaveQuestion(Question question)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedures.QuestionSave;
                cmd.Parameters.AddWithValue("ID", question.ID);
                cmd.Parameters.AddWithValue("Question", question.QuestionText);
                cmd.Parameters.AddWithValue("OptionA", question.OptionA);
                cmd.Parameters.AddWithValue("OptionB", question.OptionB);
                cmd.Parameters.AddWithValue("OptionC", question.OptionC);
                cmd.Parameters.AddWithValue("OptionD", question.OptionD);
                cmd.Parameters.AddWithValue("Answer", question.Answer);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                return false;
            }


            return true;

        }

        public static int GetQuestionCount()
        {
            int questionCount;
            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedures.QuestionCount;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                questionCount = Convert.ToInt32(reader["QuestionCount"]);
                conn.Close();
            }
            catch (Exception e)
            {
                return 0;
            }

            return questionCount;

        }

        public static int GetUserCount()
        {
            int userCount;
            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedures.UserCount;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                userCount = Convert.ToInt32(reader["UserCount"]);
                conn.Close();
            }
            catch (Exception)
            {
                return 0;
            }

            return userCount;

        }

        public static int GetExamCount()
        {
            int examCount;
            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedures.ExamCount;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                examCount = Convert.ToInt32(reader["ExamCount"]);
                conn.Close();
            }
            catch (Exception)
            {
                return 0;
            }

            return examCount;

        }

        public static bool SaveResult(Result result)
        {
            SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedures.SaveResult;
            cmd.Parameters.AddWithValue("ID", result.ID);
            cmd.Parameters.AddWithValue("StudentId", result.StudentID);
            cmd.Parameters.AddWithValue("Mark", result.Mark);
            cmd.Parameters.AddWithValue("ExamName", result.ExamName);
            cmd.Parameters.AddWithValue("ExamDate", Convert.ToDateTime(result.ExamDate));
            cmd.Parameters.AddWithValue("TotalTime", result.TotalTime);
            cmd.Parameters.AddWithValue("Skipped", result.Skipped);
            cmd.Parameters.AddWithValue("Wrong", result.Wrong);
            cmd.Parameters.AddWithValue("TotalQuestions", result.TotalQuestions);
            cmd.Parameters.AddWithValue("Remarks", "OS version : " + Environment.OSVersion + " System Username : " + Environment.UserName);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public static bool SaveUser(Student student)
        {

            SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedures.StudentSave;

            cmd.Parameters.AddWithValue("Id", student.ID);
            cmd.Parameters.AddWithValue("Name", student.Name);
            cmd.Parameters.AddWithValue("RegNumber", student.RegNumber);
            cmd.Parameters.AddWithValue("Shift", student.Shift);
            cmd.Parameters.AddWithValue("Trade", student.Trade);

            cmd.ExecuteNonQuery();
            conn.Close();


            return true;

        }

        public static bool DeleteUser(int id)
        {

            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedures.DeleteUser;
                cmd.Parameters.AddWithValue("ID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteQuestion(int id)
        {

            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConstants.GetServer() + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProcedures.DeleteQuestion;
                cmd.Parameters.AddWithValue("ID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool TestConnection(string server)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=" + server + DatabaseConstants.MSSQLConnectionString);
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
