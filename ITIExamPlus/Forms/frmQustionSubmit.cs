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
    public partial class frmQustionSubmit : Form
    {
        Question _question = new Question();
        List<Question> _questions = new List<Question>();
        Dictionary<int, int> _idMapper = new Dictionary<int, int>();

        public frmQustionSubmit()
        {
            InitializeComponent();
        }

        private void frmQustionSubmit_Click(object sender, EventArgs e)
        {
        }

        private void frmQustionSubmit_Load(object sender, EventArgs e)
        {
            FormSetup();

            int totalQuestionCount = DataLayer.GetQuestionCount();
        }

        private void BindSavedQuestions()
        {
            _questions = DataLayer.GetAllQuestions();
            drpQuestions.Text = "";
            drpQuestions.Items.Clear();
            _idMapper.Clear();
            foreach (Question item in _questions)
            {
                _idMapper.Add(item.ID, drpQuestions.Items.Count);
                drpQuestions.Items.Add(item.QuestionText);
            }
            
        }
        private bool ValidateQuestion()
        {
            bool optionSelected = false;
            foreach (Control C in this.pnlQustion.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.RadioButton))
                {
                    RadioButton temp = (RadioButton)C;
                    if (temp.Tag == "OP" && temp.Checked == true)
                    {
                        optionSelected = true;
                    }
                }
            }
            if (optionSelected==true&&txtQustion.Text != "" && txtOptionA.Text != "" && txtOptionB.Text != "" && txtOptionC.Text != "" && txtOptionD.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Question SetupQuestion()
        {
            Question question = new Question();
            question.QuestionText = txtQustion.Text.Trim();
            question.OptionA = txtOptionA.Text.Trim();
            question.OptionB = txtOptionB.Text.Trim();
            question.OptionC = txtOptionC.Text.Trim();
            question.OptionD = txtOptionD.Text.Trim();
            if (rdbA.Checked)
            {
                question.Answer = (int)Options.OptionA; //A
            }
            else if (rdbB.Checked)
            {
                question.Answer = (int)Options.OptionB ; //B
            }
            else if (rdbC.Checked)
            {
                question.Answer = (int)Options.OptionC;//C
            }
            else if (rdbD.Checked)
            {
                question.Answer = (int)Options.OptionD;//D
            }

            if (question.Answer == (int)Options.NoAnswer)
            {
                question.Answer = (int)Options.OptionA;
            }
            return question;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateQuestion())
            {
                DialogResult dialogResult = MessageBox.Show(Messages.DoYouWantToSave, ProjectConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {

                    if (DataLayer.SaveQuestion(SetupQuestion()))
                    {
                        MessageBox.Show(Messages.QuestionSaved, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        QuestionCountUpdate();
                        BindSavedQuestions();
                        ClearWinodow();
                        
                    }
                }
            }
            else
            {
                MessageBox.Show(Messages.QuestionInvalid, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void QuestionCountUpdate()
        {
            lblTotalQuestions.Text = "Total Questions : " + DataLayer.GetQuestionCount().ToString();
        }

        private void FormSetup()
        {
            pnlQustion.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - (pnlQustion.Width / 2);
            pnlQustion.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - (pnlQustion.Height / 2);
            lblMenu.Left = Screen.PrimaryScreen.WorkingArea.Width - lblMenu.Width - 20;
            lblTotalQuestions.Top = Screen.PrimaryScreen.WorkingArea.Height - 10;
            BindSavedQuestions();
            QuestionCountUpdate();

        }

        private void ClearWinodow()
        {
            txtQustion.Text = txtOptionA.Text = txtOptionB.Text = txtOptionC.Text = txtOptionD.Text = "";
            rdbA.Checked = rdbB.Checked = rdbC.Checked = rdbD.Checked = false;
            txtOptionA.Font =txtOptionB.Font = txtOptionC.Font = txtOptionD.Font = new Font(txtOptionA.Font, FontStyle.Regular);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearWinodow();
        }

        private void txtQustion_TextChanged(object sender, EventArgs e)
        {
            lblQuestionTextCount.Text = txtQustion.Text.Length.ToString();
        }

        private void rdbA_CheckedChanged(object sender, EventArgs e)
        {
            SetAnswerBold(rdbA, txtOptionA);
        }

        private void SetAnswerBold(RadioButton radioButton, TextBox textBox)
        {
            if (radioButton.Checked)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            }
            else
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
            }
        }

        private void rdbB_CheckedChanged(object sender, EventArgs e)
        {
            SetAnswerBold(rdbB, txtOptionB);
        }

        private void rdbC_CheckedChanged(object sender, EventArgs e)
        {
            SetAnswerBold(rdbC, txtOptionC);
        }

        private void rdbD_CheckedChanged(object sender, EventArgs e)
        {
            SetAnswerBold(rdbD, txtOptionD);
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            WindowHandler.LoadNewForm(new frmAdminMenu(), this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (drpQuestions.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show(Messages.QuestionDelete, ProjectConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataLayer.DeleteQuestion(_idMapper.Keys.ElementAt(drpQuestions.SelectedIndex));
                    _idMapper.Keys.ElementAt(drpQuestions.SelectedIndex);
                    BindSavedQuestions();
                    MessageBox.Show(Messages.QuestionDeleted, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuestionCountUpdate();
                }
            }
            else
            {
                MessageBox.Show(Messages.SelectQuestion, ProjectConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

