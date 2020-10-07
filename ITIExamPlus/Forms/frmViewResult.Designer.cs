namespace ITIExamPlus.Forms
{
    partial class frmViewResult
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.lstHeading = new System.Windows.Forms.ListBox();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(35, 36);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(171, 24);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Results";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(718, 24);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(107, 16);
            this.lblMenu.TabIndex = 21;
            this.lblMenu.Text = "Back To Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lstresult);
            this.pnlResult.Controls.Add(this.lstHeading);
            this.pnlResult.Location = new System.Drawing.Point(39, 124);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(767, 422);
            this.pnlResult.TabIndex = 23;
            // 
            // lstresult
            // 
            this.lstresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 16;
            this.lstresult.Location = new System.Drawing.Point(8, 36);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(756, 372);
            this.lstresult.TabIndex = 23;
            // 
            // lstHeading
            // 
            this.lstHeading.BackColor = System.Drawing.SystemColors.Control;
            this.lstHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHeading.FormattingEnabled = true;
            this.lstHeading.ItemHeight = 15;
            this.lstHeading.Location = new System.Drawing.Point(8, 16);
            this.lstHeading.Name = "lstHeading";
            this.lstHeading.Size = new System.Drawing.Size(756, 15);
            this.lstHeading.TabIndex = 24;
            // 
            // frmViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 695);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewResult";
            this.Text = "frmViewResult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewResult_Load);
            this.pnlResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.ListBox lstresult;
        private System.Windows.Forms.ListBox lstHeading;
    }
}