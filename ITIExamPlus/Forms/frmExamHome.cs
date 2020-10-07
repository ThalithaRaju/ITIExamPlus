using ITIExamPlus.Constants;
using ITIExamPlus.Core;
using ITIExamPlus.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIExamPlus.Forms
{
    enum Options
    {
        OptionA = 1
            , OptionB = 2
            , OptionC = 3
            , OptionD = 4
            , NoAnswer = 0
    }

    public partial class frmExamHome : Form
    {
        Stopwatch _examTimer = new Stopwatch();
        Student _student = new Student();
        int _questionCount = -1;
        int _maxQuestionCount;
        List<Question> _questions = new List<Question>();
        Result _result = new Result();

        public frmExamHome()
        {
            InitializeComponent();
        }

        public frmExamHome(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void frmExamHome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Exit ?", ProjectConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                    Environment.Exit(0);
            }
        }

        private void frmExamHome_Load(object sender, EventArgs e)
        {
            FormSetup();
        }

        private Result MakeResult()
        {
            int skipped = 0;
            int mark = 0;
            int wrong = 0;
            Result result = new Result();
            
            for (int i = 0; i < _questions.Count; i++)
            {
                if (_questions[i].SelectedAnswer == 0)
                {
                    skipped++;
                }
                else if (_questions[i].SelectedAnswer == _questions[i].Answer)
                {
                    mark++;
                }
                else if (_questions[i].SelectedAnswer != _questions[i].Answer)
                {
                    wrong++;
                }

            }
            DateTime dateTime = DateTime.ParseExact(lblTime.Text, "HH:mm:ss",
                                        CultureInfo.InvariantCulture);

            result.ExamDate = DateTime.Now.ToString();
            result.TotalQuestions = _questions.Count;
            result.StudentID = _student.ID;
            result.TotalTime = lblTime.Text;
            result.Wrong = wrong;
            result.Skipped = skipped;
            result.Mark = mark;
            result.ExamName = "Trail Exam";
            return result;

        }

        private void FinishExam()
        {
            _examTimer.Stop();
            _result = MakeResult();
            DataLayer.SaveResult(_result);

            pnlQuestn.Visible = false;
            lblExamComplited.Visible = true;
            btnFinish.Text = "Exit";

        }

        private void SetAnswerOptionBold(RadioButton radioButton)
        {

            if (radioButton.Checked)
            {
                radioButton.Font = new Font(radioButton.Font, FontStyle.Bold);
            }
            else
            {
                radioButton.Font = new Font(radioButton.Font, FontStyle.Regular);
            }

            foreach (Control C in this.pnlQuestn.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.RadioButton))
                {
                    RadioButton temp = (RadioButton)C;
                    if (temp.Tag == "OP" && temp.Checked == false)
                    {
                        temp.Font = new Font(temp.Font, FontStyle.Regular);
                    }
                }
            }
        }

        private void SetAnswerOptionNormal()
        {
            rdbOptionA.Font = new Font(rdbOptionA.Font, FontStyle.Regular);
            rdbOptionB.Font = new Font(rdbOptionB.Font, FontStyle.Regular);
            rdbOptionC.Font = new Font(rdbOptionC.Font, FontStyle.Regular);
            rdbOptionD.Font = new Font(rdbOptionD.Font, FontStyle.Regular);
            rdbOptionA.Checked = rdbOptionB.Checked = rdbOptionC.Checked = rdbOptionD.Checked = false;

        }

        private void FormSetup()
        {
            //picExam.Left= Screen.PrimaryScreen.WorkingArea.Width / 2 - (picExam.Width / 2);
            //picExam.Top = btnStart.Top - picExam.Height - 5;
            pnlQuestn.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - (pnlQuestn.Width / 2);
            pnlQuestn.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - (pnlQuestn.Top / 2) - 150;

            lblStudentName.Text = lblStudentName.Text + _student.Name;
            lblQuestenCount.Left = Screen.PrimaryScreen.WorkingArea.Width - lblQuestenCount.Width - 20;

            lblTime.Top = Screen.PrimaryScreen.WorkingArea.Height - 10;

            pnlStart.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - pnlStart.Width / 2;
            pnlStart.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - pnlStart.Height / 2;

            lblExamComplited.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - lblExamComplited.Width / 2;
            lblExamComplited.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - lblExamComplited.Height / 2;

            btnFinish.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - btnFinish.Width / 2;

            btnFinish.Top = pnlQuestn.Top + pnlQuestn.Height + 100;
            _questions = DataLayer.GetAllQuestions();
            _maxQuestionCount = _questions.Count;

            lblStudentName.Text = "Welcome " + _student.Name;

        }

        private void QuestenPanelCenterAlign()
        {

        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartExam();
        }

        private void StartExam()
        {
            pnlQuestn.Visible = true;
            pnlStart.Visible = false;
            QuestionSeek(true);
            _examTimer.Start();
            tmrExam.Enabled = true;
            btnFinish.Visible = true;
            lblTime.Visible = true;
            SetAnswerOptionNormal();
        }
        private void MarkAnswer()
        {
            try
            {
                if (rdbOptionA.Checked)
                {
                    _questions[_questionCount].SelectedAnswer = (int)Options.OptionA;
                }
                else if (rdbOptionB.Checked)
                {
                    _questions[_questionCount].SelectedAnswer = (int)Options.OptionB;
                }
                else if (rdbOptionC.Checked)
                {
                    _questions[_questionCount].SelectedAnswer = (int)Options.OptionC;
                }
                else if (rdbOptionD.Checked)
                {
                    _questions[_questionCount].SelectedAnswer = (int)Options.OptionD;
                }
            }
            catch (Exception)
            {


            }
        }

        private void MarkAnsweredQueston()
        {
            try
            {
                if (_questions[_questionCount].SelectedAnswer == (int)Options.OptionA)
                {
                    rdbOptionA.Checked = true;
                    SetAnswerOptionBold(rdbOptionA);
                }
                else if (_questions[_questionCount].SelectedAnswer == (int)Options.OptionB)
                {
                    rdbOptionB.Checked = true;
                    SetAnswerOptionBold(rdbOptionB);
                }
                else if (_questions[_questionCount].SelectedAnswer == (int)Options.OptionC)
                {
                    rdbOptionC.Checked = true;
                    SetAnswerOptionBold(rdbOptionC);
                }
                else if (_questions[_questionCount].SelectedAnswer == (int)Options.OptionD)
                {
                    rdbOptionD.Checked = true;
                    SetAnswerOptionBold(rdbOptionD);
                }
                else if (_questions[_questionCount].SelectedAnswer == (int)Options.NoAnswer)
                {
                    // rdbOptionD.Checked = rdbOptionC.Checked = rdbOptionB.Checked = rdbOptionA.Checked = false;
                    SetAnswerOptionNormal();
                }
            }
            catch (Exception)
            {


            }
        }

        private void QuestionSeek(bool questonNextFlag)
        {
            if (questonNextFlag)
            {
                if (_maxQuestionCount - 1 > _questionCount)
                {
                    _questionCount++;

                    lblQuestionText.Text = _questionCount+1 + ". " + _questions[_questionCount].QuestionText;
                    rdbOptionA.Text = _questions[_questionCount].OptionA;
                    rdbOptionB.Text = _questions[_questionCount].OptionB;
                    rdbOptionC.Text = _questions[_questionCount].OptionC;
                    rdbOptionD.Text = _questions[_questionCount].OptionD;

                }
            }
            else
            {
                if (_questionCount != 0)
                {
                    _questionCount--;
                    // SetAnswerOptionNormal();
                    lblQuestionText.Text =_questionCount+1+". "+ _questions[_questionCount].QuestionText;
                    rdbOptionA.Text = _questions[_questionCount].OptionA;
                    rdbOptionB.Text = _questions[_questionCount].OptionB;
                    rdbOptionC.Text = _questions[_questionCount].OptionC;
                    rdbOptionD.Text = _questions[_questionCount].OptionD;
                    // lblQuestenCount.Text = "Question " + (_questionCount+1).ToString() + "/" + "100";
                }
            }
            lblQuestenCount.Text = "Question " + (_questionCount+1).ToString() + "/" + _questions.Count.ToString();
            if (_questionCount == 0)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
            }

            if (_questionCount == _maxQuestionCount - 1)
            {
                btnConform.Enabled = false;
            }
            else
            {
                btnConform.Enabled = true;
            }
            MarkAnsweredQueston();
            
        }

        private void btnConform_Click(object sender, EventArgs e)
        {
            QuestionSeek(true);
        }

        private void tmrExam_Tick(object sender, EventArgs e)
        {

            lblTime.Text = String.Format("{0:hh\\:mm\\:ss}", _examTimer.Elapsed);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            QuestionSeek(false);
        }

        private void rdbOptionA_Click(object sender, EventArgs e)
        {
            SetAnswerOptionBold(rdbOptionA);
            MarkAnswer();
        }

        private void rdbOptionB_Click(object sender, EventArgs e)
        {
            SetAnswerOptionBold(rdbOptionB);
            MarkAnswer();
        }

        private void rdbOptionC_Click(object sender, EventArgs e)
        {
            SetAnswerOptionBold(rdbOptionC);
            MarkAnswer();
        }

        private void rdbOptionD_Click(object sender, EventArgs e)
        {
            SetAnswerOptionBold(rdbOptionD);
            MarkAnswer();
        }

      
       
        private void BackToLogin()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (btnFinish.Text == "Exit")
            {
                BackToLogin();
            }
            else
            {
                FinishExam();
            }
        }

        private void frmExamHome_Click(object sender, EventArgs e)
        {
           // Environment.Exit(0);
        }

      
    }
}
