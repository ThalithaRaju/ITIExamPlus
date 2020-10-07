namespace ITIExamPlus.Forms
{
    partial class frmAdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenuSide = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblViewQuestions = new System.Windows.Forms.Label();
            this.lblAddQuestions = new System.Windows.Forms.Label();
            this.lblViewResults = new System.Windows.Forms.Label();
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblTotalExam = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblHeadBanner = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuSide
            // 
            this.lblMenuSide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMenuSide.Location = new System.Drawing.Point(0, 0);
            this.lblMenuSide.Name = "lblMenuSide";
            this.lblMenuSide.Size = new System.Drawing.Size(230, 571);
            this.lblMenuSide.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenu.Controls.Add(this.lblLogin);
            this.pnlMenu.Controls.Add(this.lblViewQuestions);
            this.pnlMenu.Controls.Add(this.lblAddQuestions);
            this.pnlMenu.Controls.Add(this.lblViewResults);
            this.pnlMenu.Controls.Add(this.lblAddNewUser);
            this.pnlMenu.Location = new System.Drawing.Point(-45, 166);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(275, 329);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Silver;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(46, 274);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblLogin.Size = new System.Drawing.Size(232, 55);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.lblAddNewUser_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblAddNewUser_MouseLeave);
            // 
            // lblViewQuestions
            // 
            this.lblViewQuestions.BackColor = System.Drawing.Color.Silver;
            this.lblViewQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewQuestions.Location = new System.Drawing.Point(46, 211);
            this.lblViewQuestions.Name = "lblViewQuestions";
            this.lblViewQuestions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblViewQuestions.Size = new System.Drawing.Size(232, 55);
            this.lblViewQuestions.TabIndex = 7;
            this.lblViewQuestions.Text = "View Questions";
            this.lblViewQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblViewQuestions.Click += new System.EventHandler(this.lblViewQuestions_Click);
            this.lblViewQuestions.MouseEnter += new System.EventHandler(this.lblAddNewUser_MouseEnter);
            this.lblViewQuestions.MouseLeave += new System.EventHandler(this.lblAddNewUser_MouseLeave);
            // 
            // lblAddQuestions
            // 
            this.lblAddQuestions.BackColor = System.Drawing.Color.Silver;
            this.lblAddQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuestions.Location = new System.Drawing.Point(46, 80);
            this.lblAddQuestions.Name = "lblAddQuestions";
            this.lblAddQuestions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAddQuestions.Size = new System.Drawing.Size(232, 55);
            this.lblAddQuestions.TabIndex = 6;
            this.lblAddQuestions.Text = "Questions Manage";
            this.lblAddQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddQuestions.Click += new System.EventHandler(this.lblAddQuestions_Click);
            this.lblAddQuestions.MouseEnter += new System.EventHandler(this.lblAddNewUser_MouseEnter);
            this.lblAddQuestions.MouseLeave += new System.EventHandler(this.lblAddNewUser_MouseLeave);
            // 
            // lblViewResults
            // 
            this.lblViewResults.BackColor = System.Drawing.Color.Silver;
            this.lblViewResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewResults.Location = new System.Drawing.Point(46, 147);
            this.lblViewResults.Name = "lblViewResults";
            this.lblViewResults.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblViewResults.Size = new System.Drawing.Size(232, 55);
            this.lblViewResults.TabIndex = 5;
            this.lblViewResults.Text = "View Results";
            this.lblViewResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblViewResults.Click += new System.EventHandler(this.lblViewResults_Click);
            this.lblViewResults.MouseEnter += new System.EventHandler(this.lblAddNewUser_MouseEnter);
            this.lblViewResults.MouseLeave += new System.EventHandler(this.lblAddNewUser_MouseLeave);
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.BackColor = System.Drawing.Color.Silver;
            this.lblAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewUser.Location = new System.Drawing.Point(46, 13);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAddNewUser.Size = new System.Drawing.Size(232, 55);
            this.lblAddNewUser.TabIndex = 4;
            this.lblAddNewUser.Text = "User Manage";
            this.lblAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddNewUser.Click += new System.EventHandler(this.lblAddNewUser_Click);
            this.lblAddNewUser.MouseEnter += new System.EventHandler(this.lblAddNewUser_MouseEnter);
            this.lblAddNewUser.MouseLeave += new System.EventHandler(this.lblAddNewUser_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 55);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblTotalExam);
            this.pnlDashboard.Controls.Add(this.lblTotalUsers);
            this.pnlDashboard.Controls.Add(this.lblTotalQuestions);
            this.pnlDashboard.Location = new System.Drawing.Point(239, 236);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(344, 287);
            this.pnlDashboard.TabIndex = 10;
            // 
            // lblTotalExam
            // 
            this.lblTotalExam.AutoSize = true;
            this.lblTotalExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExam.Location = new System.Drawing.Point(45, 192);
            this.lblTotalExam.Name = "lblTotalExam";
            this.lblTotalExam.Size = new System.Drawing.Size(228, 31);
            this.lblTotalExam.TabIndex = 2;
            this.lblTotalExam.Text = "Total Exams       : ";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(45, 125);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(225, 31);
            this.lblTotalUsers.TabIndex = 1;
            this.lblTotalUsers.Text = "Total Users        : ";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuestions.Location = new System.Drawing.Point(45, 58);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(227, 31);
            this.lblTotalQuestions.TabIndex = 0;
            this.lblTotalQuestions.Text = "Total Questions : ";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(874, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(34, 55);
            this.lblClose.TabIndex = 22;
            this.lblClose.Text = " X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblHeadBanner
            // 
            this.lblHeadBanner.BackColor = System.Drawing.Color.LightGray;
            this.lblHeadBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadBanner.Location = new System.Drawing.Point(230, 0);
            this.lblHeadBanner.Name = "lblHeadBanner";
            this.lblHeadBanner.Size = new System.Drawing.Size(232, 55);
            this.lblHeadBanner.TabIndex = 23;
            this.lblHeadBanner.Text = "Dashboard";
            this.lblHeadBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 675);
            this.Controls.Add(this.lblHeadBanner);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblMenuSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMenu";
            this.Text = "frmAdminMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuSide;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblAddQuestions;
        private System.Windows.Forms.Label lblViewResults;
        private System.Windows.Forms.Label lblAddNewUser;
        private System.Windows.Forms.Label lblViewQuestions;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblTotalExam;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblHeadBanner;
    }
}