using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIExamPlus.Core
{
  public  class WindowHandler
    {

        public static void LoadNewForm(Form newForom, Form prvForm)
        {
             Form form = new Form();
            form = newForom;
            form.Show();
            prvForm.Hide();
        }
        public static string PresentTime(string format= "h:mm:ss tt")
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
