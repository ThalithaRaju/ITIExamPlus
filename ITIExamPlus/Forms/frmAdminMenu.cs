using ITIExamPlus.Constants;
using ITIExamPlus.Core;
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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            FormSetup();
        }

        private void FormSetup()
        {
            //  pn.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - (pnlQuestn.Width / 2);
            lblMenuSide.Height = Screen.PrimaryScreen.WorkingArea.Height+200;
            pnlMenu.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - (pnlMenu.Top / 2) ;

            int tempDashboardArea = Screen.PrimaryScreen.WorkingArea.Width - pnlMenu.Width;

            pnlDashboard.Left = tempDashboardArea / 2 ;
            pnlDashboard.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - pnlDashboard.Height / 2;

            lblClose.Left = Screen.PrimaryScreen.WorkingArea.Width - 25;
            lblHeadBanner.Left = lblMenuSide.Width;
            lblHeadBanner.Width = Screen.PrimaryScreen.WorkingArea.Width - lblMenuSide.Width-lblClose.Width+4;
            DashBoardLoad();
        }

        private void DashBoardLoad()
        {
            lblTotalUsers.Text = lblTotalUsers.Text+DataLayer.GetUserCount().ToString();
            lblTotalQuestions.Text = lblTotalQuestions.Text+DataLayer.GetQuestionCount().ToString();
            lblTotalExam.Text= lblTotalExam.Text + DataLayer.GetExamCount().ToString();

        }
        private void lblAddNewUser_Click(object sender, EventArgs e)
        {
            WindowHandler.LoadNewForm(new frmAddUser(), this);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            WindowHandler.LoadNewForm(new frmLogin(), this);
        }

        private void lblAddQuestions_Click(object sender, EventArgs e)
        {
            WindowHandler.LoadNewForm(new frmQustionSubmit(), this);
        }

        private void lblAddNewUser_MouseEnter(object sender, EventArgs e)
        {
            Label lbl =new Label();
            lbl = (Label)sender;
            lbl.Text = "  " + lbl.Text;
            lbl.BackColor = Color.LightGray;
        }

        private void lblAddNewUser_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl = (Label)sender;
            lbl.Text =lbl.Text.Remove(0,2);
            lbl.BackColor = Color.Silver;
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.Left = lblClose.Left - 5;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.Left = lblClose.Left + 5;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblViewQuestions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu disabled !", ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblViewResults_Click(object sender, EventArgs e)
        {
            WindowHandler.LoadNewForm(new frmViewResult(), this);

        }
    }
}
