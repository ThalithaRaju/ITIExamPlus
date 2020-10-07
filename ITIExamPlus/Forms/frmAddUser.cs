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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIExamPlus.Forms
{
    public partial class frmAddUser : Form
    {
        List<Student> _users = new List<Student>();
        Dictionary<int, int> _idMapper = new Dictionary<int, int>();
        int _userCount = 0;
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            FormSetup();
        }
        private void FormSetup()
        {
            pnlUser.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - (pnlUser.Width / 2);
            pnlUser.Height = Screen.PrimaryScreen.WorkingArea.Height + 200;
            pnlUser.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - (pnlUser.Top / 2) - 150;

            lblMenu.Left = Screen.PrimaryScreen.WorkingArea.Width - lblMenu.Width - 20;
            LoadPresentUsers();


        }
        private void LoadPresentUsers()
        {
            _userCount = 0;
            _idMapper.Clear();
            lstPresentUsers.Items.Clear();
            _users = DataLayer.GetUsers();
            foreach (Student item in _users)
            {
                // lstPresentUsers.Items
                _idMapper.Add(item.ID, _userCount);
                lstPresentUsers.Items.Add(++_userCount + ". " + item.Name);
            }
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            WindowHandler.LoadNewForm(new frmAdminMenu(), this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateTextbox(pnlUser))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save ?", ProjectConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {

                    Student student = new Student();
                    student.ID = 0;
                    student.Name = txtName.Text.Trim();
                    student.Password = drpTraide.Text.Trim();
                    student.Shift = drpShift.Text.Trim();
                    student.Trade = drpTraide.Text.Trim();
                    student.RegNumber = txtRegisterNumber.Text.Trim();
                    DataLayer.SaveUser(student);
                    MessageBox.Show(Messages.UserSave, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPresentUsers();
                    ClearAllTextFelds(pnlUser);
                }
            }
            else
            {
                MessageBox.Show(Messages.InvalidUserInformation, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ClearAllTextFelds(Panel panel)
        {
            foreach (Control C in panel.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    TextBox temp = (TextBox)C;
                    temp.Text = "";

                }
            }
            foreach (Control C in panel.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    ComboBox temp = (ComboBox)C;
                    temp.Text = "";

                }
            }
        }

        private bool ValidateTextbox(Panel panel)
        {
            bool isValid = true;

            foreach (Control C in panel.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    TextBox temp = (TextBox)C;
                    if (temp.Text == "")
                    {
                        isValid = false;
                    }
                }
            }
            foreach (Control C in panel.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    ComboBox temp = (ComboBox)C;
                    if (temp.Text == "")
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextFelds(pnlUser);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPresentUsers.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show(Messages.UserDelete, ProjectConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataLayer.DeleteUser(_idMapper.Keys.ElementAt(lstPresentUsers.SelectedIndex));
                    _idMapper.Keys.ElementAt(lstPresentUsers.SelectedIndex);
                    LoadPresentUsers();
                    MessageBox.Show(Messages.UserDeleted, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show(Messages.SelectUser, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        
    }
}
