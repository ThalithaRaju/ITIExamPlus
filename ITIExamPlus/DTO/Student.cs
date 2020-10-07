using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIExamPlus.DTO
{
  public  class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Trade { get; set; }
        public string Shift { get; set; }
        public string Password { get; set; }
        public string CreatedTime { get; set; }
    }
}
