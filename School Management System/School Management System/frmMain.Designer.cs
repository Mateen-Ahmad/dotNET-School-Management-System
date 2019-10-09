namespace School_Management_System
{
    partial class frmMain
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
            this.ucHome1 = new School_Management_System.ucHome();
            this.ucStudents1 = new School_Management_System.ucStudents();
            this.usSideNav1 = new School_Management_System.usSideNav();
            this.ucTeacherPay1 = new School_Management_System.ucTeacherPay();
            this.ucAdmin1 = new School_Management_System.ucAdmin();
            this.SuspendLayout();
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(175, 48);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(730, 356);
            this.ucHome1.TabIndex = 4;
            this.ucHome1.Load += new System.EventHandler(this.ucHome1_Load);
            // 
            // ucStudents1
            // 
            this.ucStudents1.Location = new System.Drawing.Point(166, 48);
            this.ucStudents1.Name = "ucStudents1";
            this.ucStudents1.Size = new System.Drawing.Size(839, 341);
            this.ucStudents1.TabIndex = 2;
            this.ucStudents1.Load += new System.EventHandler(this.ucStudents1_Load);
            // 
            // usSideNav1
            // 
            this.usSideNav1.Location = new System.Drawing.Point(-2, 38);
            this.usSideNav1.Name = "usSideNav1";
            this.usSideNav1.Size = new System.Drawing.Size(184, 427);
            this.usSideNav1.TabIndex = 0;
            this.usSideNav1.Load += new System.EventHandler(this.usSideNav1_Load);
            // 
            // ucTeacherPay1
            // 
            this.ucTeacherPay1.Location = new System.Drawing.Point(175, 38);
            this.ucTeacherPay1.Name = "ucTeacherPay1";
            this.ucTeacherPay1.Size = new System.Drawing.Size(717, 408);
            this.ucTeacherPay1.TabIndex = 5;
            // 
            // ucAdmin1
            // 
            this.ucAdmin1.Location = new System.Drawing.Point(166, 12);
            this.ucAdmin1.Name = "ucAdmin1";
            this.ucAdmin1.Size = new System.Drawing.Size(791, 471);
            this.ucAdmin1.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 493);
            this.Controls.Add(this.ucAdmin1);
            this.Controls.Add(this.ucTeacherPay1);
            this.Controls.Add(this.ucHome1);
            this.Controls.Add(this.ucStudents1);
            this.Controls.Add(this.usSideNav1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usSideNav usSideNav1;
        private ucStudents ucStudents1;
        private ucHome ucHome1;
        private ucTeacherPay ucTeacherPay1;
        private ucAdmin ucAdmin1;
    }
}