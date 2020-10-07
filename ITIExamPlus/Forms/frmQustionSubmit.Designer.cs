namespace ITIExamPlus.Forms
{
    partial class frmQustionSubmit
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
            this.pnlQustion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.drpQuestions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuestionTextCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.txtQustion = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlQustion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQustion
            // 
            this.pnlQustion.Controls.Add(this.label1);
            this.pnlQustion.Controls.Add(this.btnDelete);
            this.pnlQustion.Controls.Add(this.drpQuestions);
            this.pnlQustion.Controls.Add(this.label5);
            this.pnlQustion.Controls.Add(this.lblQuestionTextCount);
            this.pnlQustion.Controls.Add(this.label4);
            this.pnlQustion.Controls.Add(this.label3);
            this.pnlQustion.Controls.Add(this.label2);
            this.pnlQustion.Controls.Add(this.lblOptionA);
            this.pnlQustion.Controls.Add(this.rdbC);
            this.pnlQustion.Controls.Add(this.rdbD);
            this.pnlQustion.Controls.Add(this.rdbB);
            this.pnlQustion.Controls.Add(this.rdbA);
            this.pnlQustion.Controls.Add(this.btnClear);
            this.pnlQustion.Controls.Add(this.btnSave);
            this.pnlQustion.Controls.Add(this.txtOptionD);
            this.pnlQustion.Controls.Add(this.txtOptionC);
            this.pnlQustion.Controls.Add(this.txtOptionB);
            this.pnlQustion.Controls.Add(this.txtOptionA);
            this.pnlQustion.Controls.Add(this.txtQustion);
            this.pnlQustion.Location = new System.Drawing.Point(145, 96);
            this.pnlQustion.Name = "pnlQustion";
            this.pnlQustion.Size = new System.Drawing.Size(933, 516);
            this.pnlQustion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Saved Questions";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(824, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 21);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // drpQuestions
            // 
            this.drpQuestions.FormattingEnabled = true;
            this.drpQuestions.Items.AddRange(new object[] {
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
            this.drpQuestions.Location = new System.Drawing.Point(50, 30);
            this.drpQuestions.Name = "drpQuestions";
            this.drpQuestions.Size = new System.Drawing.Size(768, 21);
            this.drpQuestions.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Question";
            // 
            // lblQuestionTextCount
            // 
            this.lblQuestionTextCount.Location = new System.Drawing.Point(824, 246);
            this.lblQuestionTextCount.Name = "lblQuestionTextCount";
            this.lblQuestionTextCount.Size = new System.Drawing.Size(59, 23);
            this.lblQuestionTextCount.TabIndex = 20;
            this.lblQuestionTextCount.Text = "0";
            this.lblQuestionTextCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Option D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Option C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Option B";
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionA.Location = new System.Drawing.Point(47, 279);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(53, 15);
            this.lblOptionA.TabIndex = 16;
            this.lblOptionA.Text = "Option A";
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(441, 338);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(14, 13);
            this.rdbC.TabIndex = 15;
            this.rdbC.TabStop = true;
            this.rdbC.Tag = "OP";
            this.rdbC.UseVisualStyleBackColor = true;
            this.rdbC.CheckedChanged += new System.EventHandler(this.rdbC_CheckedChanged);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(869, 338);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(14, 13);
            this.rdbD.TabIndex = 14;
            this.rdbD.TabStop = true;
            this.rdbD.Tag = "OP";
            this.rdbD.UseVisualStyleBackColor = true;
            this.rdbD.CheckedChanged += new System.EventHandler(this.rdbD_CheckedChanged);
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(869, 279);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(14, 13);
            this.rdbB.TabIndex = 13;
            this.rdbB.TabStop = true;
            this.rdbB.Tag = "OP";
            this.rdbB.UseVisualStyleBackColor = true;
            this.rdbB.CheckedChanged += new System.EventHandler(this.rdbB_CheckedChanged);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(441, 279);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(14, 13);
            this.rdbA.TabIndex = 12;
            this.rdbA.TabStop = true;
            this.rdbA.Tag = "OP";
            this.rdbA.UseVisualStyleBackColor = true;
            this.rdbA.CheckedChanged += new System.EventHandler(this.rdbA_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(338, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(477, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOptionD
            // 
            this.txtOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionD.Location = new System.Drawing.Point(477, 357);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(406, 22);
            this.txtOptionD.TabIndex = 9;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionC.Location = new System.Drawing.Point(49, 357);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(406, 22);
            this.txtOptionC.TabIndex = 8;
            // 
            // txtOptionB
            // 
            this.txtOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionB.Location = new System.Drawing.Point(477, 298);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(406, 22);
            this.txtOptionB.TabIndex = 7;
            // 
            // txtOptionA
            // 
            this.txtOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionA.Location = new System.Drawing.Point(49, 298);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(406, 22);
            this.txtOptionA.TabIndex = 6;
            // 
            // txtQustion
            // 
            this.txtQustion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQustion.Location = new System.Drawing.Point(49, 81);
            this.txtQustion.Multiline = true;
            this.txtQustion.Name = "txtQustion";
            this.txtQustion.Size = new System.Drawing.Size(834, 162);
            this.txtQustion.TabIndex = 5;
            this.txtQustion.TextChanged += new System.EventHandler(this.txtQustion_TextChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(51, 41);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(188, 24);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Submit Questions";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuestions.Location = new System.Drawing.Point(12, 595);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(111, 16);
            this.lblTotalQuestions.TabIndex = 21;
            this.lblTotalQuestions.Text = "Total Questions : ";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(1109, 23);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(43, 16);
            this.lblMenu.TabIndex = 22;
            this.lblMenu.Text = "Back";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // frmQustionSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 624);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTotalQuestions);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.pnlQustion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQustionSubmit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQustionSubmit_Load);
            this.Click += new System.EventHandler(this.frmQustionSubmit_Click);
            this.pnlQustion.ResumeLayout(false);
            this.pnlQustion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQustion;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtQustion;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestionTextCount;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox drpQuestions;
        private System.Windows.Forms.Label label1;
    }
}