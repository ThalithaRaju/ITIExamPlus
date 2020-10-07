using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIExamPlus.DTO
{
   public class Result
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int Mark { get; set; }
        public string ExamName { get; set; }
        public string Remarks { get; set; }
        public string ExamDate { get; set; }
        public string TotalTime { get; set; }
        public int Wrong { get; set; }
        public int Skipped { get; set; }
        public int TotalQuestions { get; set; }
    }
}
