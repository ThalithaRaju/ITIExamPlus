using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIExamPlus.DTO
{
  public  class Question
    {
        public int ID { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public int Answer { get; set; }
        public int SelectedAnswer { get; set; }
    }
}
