using ITIExamPlus.Constants;
using ITIExamPlus.Core;
using ITIExamPlus.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIExamPlus.Forms
{
    public partial class frmViewResult : Form
    {
        List<Result> _result = new List<Result>();
        int id = 0;
        public frmViewResult()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            WindowHandler.LoadNewForm(new frmAdminMenu(), this);
        }

        private void FormSetup()
        {
            lblMenu.Left = Screen.PrimaryScreen.WorkingArea.Width - lblMenu.Width - 20;
            pnlResult.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - (pnlResult.Width / 2);
            pnlResult.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - (pnlResult.Top / 2)-100;

            lstHeading.Items.Add("ID" + "\t" + "RegNumber" + "\t" + "Name" + "\t" + "Trade" + "\t" + "Shift" + "\t" + "Mark" + "\t" + "Wrong" + "\t" + "Skipped" + "\t" + "Total"+ "\t" + "Time Taken");
            _result = DataLayer.GetResults();

            if (_result.Count==0)
                MessageBox.Show(Messages.NoRecord, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Result item in _result)
            {
                int avg = (item.Mark / item.TotalQuestions) * 100;
                string nameSetup = item.Student.Name.Length > 6 ? item.Student.Name.Substring(0, 6) : item.Student.Name;
                id++;
                string tempResultString = id.ToString()
                + "\t" + item.Student.RegNumber
                + "\t\t" + nameSetup
                + "\t" + item.Student.Trade
                + "\t" + item.Student.Shift
                + "\t" + item.Mark
                + "\t" + item.Wrong
                + "\t" + item.Skipped
                + "\t" + item.TotalQuestions
                + "\t" + item.TotalTime;

                lstresult.Items.Add(tempResultString);
            }
        }

        private void frmViewResult_Load(object sender, EventArgs e)
        {
            FormSetup();
        }

       
    }
}
