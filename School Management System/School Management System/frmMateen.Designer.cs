namespace School_Management_System
{
    partial class frmMateen
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
            this.ucStudents1 = new School_Management_System.ucStudents();
            this.SuspendLayout();
            // 
            // usSideNav1
            // 
            this.usSideNav1.Location = new System.Drawing.Point(-15, 12);
            this.usSideNav1.Name = "usSideNav1";
            this.usSideNav1.Size = new System.Drawing.Size(184, 427);
            this.usSideNav1.TabIndex = 1;
            // 
            // ucStudents1
            // 
            this.ucStudents1.Location = new System.Drawing.Point(175, 3);
            this.ucStudents1.Name = "ucStudents1";
            this.ucStudents1.Size = new System.Drawing.Size(1060, 447);
            this.ucStudents1.TabIndex = 0;
            this.ucStudents1.Load += new System.EventHandler(this.ucStudents1_Load);
            // 
            // frmMateen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 499);
            this.Controls.Add(this.usSideNav1);
            this.Controls.Add(this.ucStudents1);
            this.Name = "frmMateen";
            this.Text = "frmMateen";
            this.ResumeLayout(false);

        }

        #endregion

        private ucStudents ucStudents1;
        private usSideNav usSideNav1;
    }
}