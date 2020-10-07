using ITIExamPlus.Constants;
using ITIExamPlus.Core;
using ITIExamPlus.Core.Common;
using ITIExamPlus.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIExamPlus.Forms
{
    public partial class frmLogin : Form
    {
        String connection;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FormSetup();
        }

        //Login Panel algin to center of the screen
        private void FormSetup()
        {
            lblTime.Text = WindowHandler.PresentTime();
            lblTime.Top = Screen.PrimaryScreen.WorkingArea.Height - 5;
            lblBeta.Top = lblTime.Top;
            lblBeta.Left = Screen.PrimaryScreen.WorkingArea.Width - 80;

            pnlLogin.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - (pnlLogin.Width / 2);
            pnlLogin.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - (pnlLogin.Top / 2);

            pnlSetup.Left = pnlLogin.Left;
            pnlSetup.Top = pnlLogin.Top + pnlLogin.Height + 30;

            lblClose.Left = Screen.PrimaryScreen.WorkingArea.Width - 25;

            connection = SystemRegistryHandler.ReadRegistry(ProjectConstants.ProjectName, "Connection", EncryptionOptions.NoEncryption);
            if (connection == null)
            {
                txtServerAndSQL.Text = Environment.MachineName+ "\\SQLEXPRESS";
                pnlSetup.Visible = true;
                HeadingVisibility(false);
            }
            else
            {
             
                HeadingVisibility(true);
            }
        }

        private void HeadingVisibility(bool isVisibile)
        {
            pnlLogin.Visible = isVisibile;
            lblTime.Visible = isVisibile;
            lblHeading.Visible = isVisibile;
            picHead.Visible = isVisibile;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1212")
            {
                WindowHandler.LoadNewForm(new frmAdminMenu(), this);
                return;
            }
            if (DataLayer.GetQuestionCount() > 0)
            {


                Student student = DataLayer.Login(txtUsername.Text, txtPassword.Text);
                if (student != null)
                {
                    WindowHandler.LoadNewForm(new frmInstructions(student), this);
                }
                else
                {
                    MessageBox.Show(Messages.LoginInvalid, ProjectConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Messages.QuestionEmpty, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.Left = lblClose.Left - 5;
            lblTime.Visible = false;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.Left = lblClose.Left + 5;
            lblTime.Visible = true;
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = WindowHandler.PresentTime();
            lblBeta.Font = new Font(lblBeta.Font, FontStyle.Bold== lblBeta.Font.Style ? FontStyle.Regular : FontStyle.Bold);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FirstStartUp();
        }
        private void FirstStartUp()
        {
            if (txtServerAndSQL.Text != "")
            {

                if (connection == null)
                {
                    if (DataLayer.TestConnection(txtServerAndSQL.Text.Trim() + DatabaseConstants.MSSQLConnectionString))
                    {
                        SystemRegistryHandler.SaveRegistry(ProjectConstants.ProjectName, "Connection", txtServerAndSQL.Text.Trim(), EncryptionOptions.NoEncryption);
                        MessageBox.Show(Messages.ConnectionOK, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pnlLogin.Visible = true;
                        pnlSetup.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(Messages.ConnectionError, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    pnlLogin.Visible = true;
                }

            }
            else
            {
                MessageBox.Show(Messages.Invalid, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
