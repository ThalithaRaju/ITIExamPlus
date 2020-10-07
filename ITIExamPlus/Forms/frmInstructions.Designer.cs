namespace ITIExamPlus.Forms
{
    partial class frmInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructions));
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.chkDisagree = new System.Windows.Forms.CheckBox();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoader = new System.Windows.Forms.Label();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlLoader = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(329, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(116, 24);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Instructions";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkDisagree);
            this.pnlMain.Controls.Add(this.chkAgree);
            this.pnlMain.Controls.Add(this.lblHeading);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(184, 215);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(780, 378);
            this.pnlMain.TabIndex = 4;
            // 
            // chkDisagree
            // 
            this.chkDisagree.AutoSize = true;
            this.chkDisagree.Location = new System.Drawing.Point(626, 348);
            this.chkDisagree.Name = "chkDisagree";
            this.chkDisagree.Size = new System.Drawing.Size(68, 17);
            this.chkDisagree.TabIndex = 8;
            this.chkDisagree.Text = "Disagree";
            this.chkDisagree.UseVisualStyleBackColor = true;
            this.chkDisagree.Click += new System.EventHandler(this.chkDisagree_Click);
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Location = new System.Drawing.Point(702, 348);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(54, 17);
            this.chkAgree.TabIndex = 7;
            this.chkAgree.Text = "Agree";
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.Click += new System.EventHandler(this.chkAgree_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 274);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblLoader
            // 
            this.lblLoader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLoader.Location = new System.Drawing.Point(15, 44);
            this.lblLoader.Name = "lblLoader";
            this.lblLoader.Size = new System.Drawing.Size(10, 23);
            this.lblLoader.TabIndex = 5;
            this.lblLoader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 1;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // pnlLoader
            // 
            this.pnlLoader.Controls.Add(this.lblLoader);
            this.pnlLoader.Location = new System.Drawing.Point(168, 96);
            this.pnlLoader.Name = "pnlLoader";
            this.pnlLoader.Size = new System.Drawing.Size(396, 100);
            this.pnlLoader.TabIndex = 6;
            this.pnlLoader.Visible = false;
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 651);
            this.Controls.Add(this.pnlLoader);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInstructions";
            this.Text = "frmInstructions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInstructions_Load);
            this.Click += new System.EventHandler(this.frmInstructions_Click);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlLoader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.Label lblLoader;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Panel pnlLoader;
        private System.Windows.Forms.CheckBox chkDisagree;
    }
}