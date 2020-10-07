namespace ITIExamPlus.Forms
{
    partial class frmExamHome
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
            this.components = new System.ComponentModel.Container();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.pnlQuestn = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnConform = new System.Windows.Forms.Button();
            this.rdbOptionD = new System.Windows.Forms.RadioButton();
            this.rdbOptionC = new System.Windows.Forms.RadioButton();
            this.rdbOptionB = new System.Windows.Forms.RadioButton();
            this.rdbOptionA = new System.Windows.Forms.RadioButton();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblQuestenCount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrExam = new System.Windows.Forms.Timer(this.components);
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblExamComplited = new System.Windows.Forms.Label();
            this.picExam = new System.Windows.Forms.PictureBox();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.pnlQuestn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExam)).BeginInit();
            this.pnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(31, 29);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(701, 24);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "--";
            // 
            // pnlQuestn
            // 
            this.pnlQuestn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestn.Controls.Add(this.btnPrevious);
            this.pnlQuestn.Controls.Add(this.btnConform);
            this.pnlQuestn.Controls.Add(this.rdbOptionD);
            this.pnlQuestn.Controls.Add(this.rdbOptionC);
            this.pnlQuestn.Controls.Add(this.rdbOptionB);
            this.pnlQuestn.Controls.Add(this.rdbOptionA);
            this.pnlQuestn.Controls.Add(this.lblQuestionText);
            this.pnlQuestn.Location = new System.Drawing.Point(185, 152);
            this.pnlQuestn.Name = "pnlQuestn";
            this.pnlQuestn.Size = new System.Drawing.Size(842, 401);
            this.pnlQuestn.TabIndex = 1;
            this.pnlQuestn.Visible = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(75, 329);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(152, 34);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnConform
            // 
            this.btnConform.Location = new System.Drawing.Point(589, 329);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(152, 34);
            this.btnConform.TabIndex = 6;
            this.btnConform.Text = "Next";
            this.btnConform.UseVisualStyleBackColor = true;
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
            // 
            // rdbOptionD
            // 
            this.rdbOptionD.AutoSize = true;
            this.rdbOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOptionD.Location = new System.Drawing.Point(582, 240);
            this.rdbOptionD.Name = "rdbOptionD";
            this.rdbOptionD.Size = new System.Drawing.Size(102, 28);
            this.rdbOptionD.TabIndex = 5;
            this.rdbOptionD.TabStop = true;
            this.rdbOptionD.Tag = "OP";
            this.rdbOptionD.Text = "Option D";
            this.rdbOptionD.UseVisualStyleBackColor = true;
            this.rdbOptionD.Click += new System.EventHandler(this.rdbOptionD_Click);
            // 
            // rdbOptionC
            // 
            this.rdbOptionC.AutoSize = true;
            this.rdbOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOptionC.Location = new System.Drawing.Point(68, 240);
            this.rdbOptionC.Name = "rdbOptionC";
            this.rdbOptionC.Size = new System.Drawing.Size(102, 28);
            this.rdbOptionC.TabIndex = 4;
            this.rdbOptionC.TabStop = true;
            this.rdbOptionC.Tag = "OP";
            this.rdbOptionC.Text = "Option C";
            this.rdbOptionC.UseVisualStyleBackColor = true;
            this.rdbOptionC.Click += new System.EventHandler(this.rdbOptionC_Click);
            // 
            // rdbOptionB
            // 
            this.rdbOptionB.AutoSize = true;
            this.rdbOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOptionB.Location = new System.Drawing.Point(582, 169);
            this.rdbOptionB.Name = "rdbOptionB";
            this.rdbOptionB.Size = new System.Drawing.Size(101, 28);
            this.rdbOptionB.TabIndex = 3;
            this.rdbOptionB.TabStop = true;
            this.rdbOptionB.Tag = "OP";
            this.rdbOptionB.Text = "Option B";
            this.rdbOptionB.UseVisualStyleBackColor = true;
            this.rdbOptionB.Click += new System.EventHandler(this.rdbOptionB_Click);
            // 
            // rdbOptionA
            // 
            this.rdbOptionA.AutoSize = true;
            this.rdbOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOptionA.Location = new System.Drawing.Point(68, 170);
            this.rdbOptionA.Name = "rdbOptionA";
            this.rdbOptionA.Size = new System.Drawing.Size(102, 28);
            this.rdbOptionA.TabIndex = 2;
            this.rdbOptionA.TabStop = true;
            this.rdbOptionA.Tag = "OP";
            this.rdbOptionA.Text = "Option A";
            this.rdbOptionA.UseVisualStyleBackColor = true;
            this.rdbOptionA.Click += new System.EventHandler(this.rdbOptionA_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(64, 40);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(710, 126);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Here are 10 GK questions for today, February 3, 2020 for various competitive exam" +
    "s in India. 1. The Mandal Commission was constituted during the tenur";
            // 
            // lblQuestenCount
            // 
            this.lblQuestenCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestenCount.Location = new System.Drawing.Point(1082, 29);
            this.lblQuestenCount.Name = "lblQuestenCount";
            this.lblQuestenCount.Size = new System.Drawing.Size(125, 24);
            this.lblQuestenCount.TabIndex = 2;
            this.lblQuestenCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(32, 732);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 24);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(37, 158);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 34);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrExam
            // 
            this.tmrExam.Tick += new System.EventHandler(this.tmrExam_Tick);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(531, 621);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(152, 34);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish Exam";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblExamComplited
            // 
            this.lblExamComplited.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamComplited.Location = new System.Drawing.Point(185, 98);
            this.lblExamComplited.Name = "lblExamComplited";
            this.lblExamComplited.Size = new System.Drawing.Size(842, 24);
            this.lblExamComplited.TabIndex = 9;
            this.lblExamComplited.Text = "Exam Complited";
            this.lblExamComplited.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExamComplited.Visible = false;
            // 
            // picExam
            // 
            this.picExam.Image = global::ITIExamPlus.Properties.Resources.OnlineExam;
            this.picExam.Location = new System.Drawing.Point(37, 3);
            this.picExam.Name = "picExam";
            this.picExam.Size = new System.Drawing.Size(131, 128);
            this.picExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExam.TabIndex = 10;
            this.picExam.TabStop = false;
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.picExam);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(906, 570);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(205, 206);
            this.pnlStart.TabIndex = 11;
            // 
            // frmExamHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 776);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.lblExamComplited);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestenCount);
            this.Controls.Add(this.pnlQuestn);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExamHome";
            this.Text = "frmExamHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExamHome_Load);
            this.Click += new System.EventHandler(this.frmExamHome_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmExamHome_KeyUp);
            this.pnlQuestn.ResumeLayout(false);
            this.pnlQuestn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExam)).EndInit();
            this.pnlStart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Panel pnlQuestn;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.RadioButton rdbOptionD;
        private System.Windows.Forms.RadioButton rdbOptionC;
        private System.Windows.Forms.RadioButton rdbOptionB;
        private System.Windows.Forms.RadioButton rdbOptionA;
        private System.Windows.Forms.Label lblQuestenCount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnConform;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrExam;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblExamComplited;
        private System.Windows.Forms.PictureBox picExam;
        private System.Windows.Forms.Panel pnlStart;
    }
}