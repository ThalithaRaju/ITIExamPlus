namespace ITIExamPlus.Forms
{
    partial class frmAddUser
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
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.drpShift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drpTraide = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lstPresentUsers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.btnDelete);
            this.pnlUser.Controls.Add(this.label5);
            this.pnlUser.Controls.Add(this.lstPresentUsers);
            this.pnlUser.Controls.Add(this.btnClear);
            this.pnlUser.Controls.Add(this.drpShift);
            this.pnlUser.Controls.Add(this.label4);
            this.pnlUser.Controls.Add(this.drpTraide);
            this.pnlUser.Controls.Add(this.label3);
            this.pnlUser.Controls.Add(this.btnSave);
            this.pnlUser.Controls.Add(this.label2);
            this.pnlUser.Controls.Add(this.label1);
            this.pnlUser.Controls.Add(this.txtRegisterNumber);
            this.pnlUser.Controls.Add(this.txtName);
            this.pnlUser.Location = new System.Drawing.Point(231, 143);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(741, 372);
            this.pnlUser.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(53, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 26);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // drpShift
            // 
            this.drpShift.FormattingEnabled = true;
            this.drpShift.Items.AddRange(new object[] {
            "A",
            "B"});
            this.drpShift.Location = new System.Drawing.Point(53, 243);
            this.drpShift.Name = "drpShift";
            this.drpShift.Size = new System.Drawing.Size(471, 21);
            this.drpShift.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Shift";
            // 
            // drpTraide
            // 
            this.drpTraide.FormattingEnabled = true;
            this.drpTraide.Items.AddRange(new object[] {
            "ICTSM",
            "COPA",
            "FPG",
            "TPES",
            "EMECH",
            "IMECH",
            "PLUMBER",
            "WELDER",
            "ELECTRICIAN",
            "ARCH",
            "DCIVIL",
            "MMV",
            "MD"});
            this.drpTraide.Location = new System.Drawing.Point(53, 187);
            this.drpTraide.Name = "drpTraide";
            this.drpTraide.Size = new System.Drawing.Size(471, 21);
            this.drpTraide.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Traide";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(329, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 26);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Register Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // txtRegisterNumber
            // 
            this.txtRegisterNumber.Location = new System.Drawing.Point(50, 131);
            this.txtRegisterNumber.Name = "txtRegisterNumber";
            this.txtRegisterNumber.Size = new System.Drawing.Size(474, 20);
            this.txtRegisterNumber.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(474, 20);
            this.txtName.TabIndex = 11;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(37, 32);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(701, 24);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Add New User";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(929, 32);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(43, 16);
            this.lblMenu.TabIndex = 20;
            this.lblMenu.Text = "Back";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // lstPresentUsers
            // 
            this.lstPresentUsers.FormattingEnabled = true;
            this.lstPresentUsers.Location = new System.Drawing.Point(563, 79);
            this.lstPresentUsers.Name = "lstPresentUsers";
            this.lstPresentUsers.Size = new System.Drawing.Size(175, 186);
            this.lstPresentUsers.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Active Users";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(563, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 26);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 644);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUser";
            this.Text = "frmAddUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox drpTraide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ListBox lstPresentUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
    }
}