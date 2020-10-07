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
    public partial class frmInstructions : Form
    {
        Student _student = new Student();
        public frmInstructions()
        {
            InitializeComponent();
        }
        public frmInstructions(Student student)
        {
            _student = student;
            InitializeComponent();
        }
        private void frmInstructions_Click(object sender, EventArgs e)
        {
          //  Environment.Exit(0);
        }

        private void frmInstructions_Load(object sender, EventArgs e)
        {
            FormSetup();
        }

        private void FormSetup()
        {
          
            pnlMain.Left = Screen.PrimaryScreen.WorkingArea.Width/2 - pnlMain.Width / 2;
            pnlMain.Top = Screen.PrimaryScreen.WorkingArea.Height/2 - pnlMain.Height / 2;

            pnlLoader.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - pnlLoader.Width / 2;
            pnlLoader.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - pnlLoader.Height / 2;
        }

        private void chkAgree_Click(object sender, EventArgs e)
        {
            if (chkAgree.Checked)
            {
                chkDisagree.Checked = false;
                pnlMain.Visible = false;
                lblHeading.Visible = false;
                pnlLoader.Visible = true;
                tmrLoad.Enabled = true;
            }
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            lblLoader.Width = lblLoader.Width + 1;
           
            if (lblLoader.Width>768)
            {
                tmrLoad.Enabled = false;
                //lblLoader.Text = "Let Start...";
                WindowHandler.LoadNewForm(new frmExamHome(_student), this);
            }
        }


        private void chkDisagree_Click(object sender, EventArgs e)
        {
            if (chkDisagree.Checked)
            {
                WindowHandler.LoadNewForm(new frmLogin(), this);
            }
        }
    }
}
