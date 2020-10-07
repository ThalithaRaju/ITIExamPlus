using ITIExamPlus.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIExamPlus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmInstructions());
            //Application.Run(new frmAdminMenu());
            //Application.Run(new frmAddUser());
            // Application.Run(new frmExamHome());
            // Application.Run(new frmQustionSubmit());

        }
    }
}
