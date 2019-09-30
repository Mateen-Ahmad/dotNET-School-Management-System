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
            this.usSideNav1 = new School_Management_System.usSideNav();
            this.ucUsers1 = new School_Management_System.ucUsers();
            this.ucStudents1 = new School_Management_System.ucStudents();
            this.SuspendLayout();
            // 
            // usSideNav1
            // 
            this.usSideNav1.Location = new System.Drawing.Point(0, -2);
            this.usSideNav1.Name = "usSideNav1";
            this.usSideNav1.Size = new System.Drawing.Size(184, 427);
            this.usSideNav1.TabIndex = 0;
            this.usSideNav1.Load += new System.EventHandler(this.usSideNav1_Load);
            // 
            // ucUsers1
            // 
            this.ucUsers1.Location = new System.Drawing.Point(235, 20);
            this.ucUsers1.Name = "ucUsers1";
            this.ucUsers1.Size = new System.Drawing.Size(683, 405);
            this.ucUsers1.TabIndex = 1;
            // 
            // ucStudents1
            // 
            this.ucStudents1.Location = new System.Drawing.Point(182, 55);
            this.ucStudents1.Name = "ucStudents1";
            this.ucStudents1.Size = new System.Drawing.Size(774, 341);
            this.ucStudents1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 437);
            this.Controls.Add(this.ucStudents1);
            this.Controls.Add(this.ucUsers1);
            this.Controls.Add(this.usSideNav1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usSideNav usSideNav1;
        private ucUsers ucUsers1;
        private ucStudents ucStudents1;
    }
}