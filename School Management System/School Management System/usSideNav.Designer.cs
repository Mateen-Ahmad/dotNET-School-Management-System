namespace School_Management_System
{
    partial class usSideNav
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(27, 48);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(129, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnFee
            // 
            this.btnFee.Location = new System.Drawing.Point(27, 101);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(129, 42);
            this.btnFee.TabIndex = 1;
            this.btnFee.Text = "Fee";
            this.btnFee.UseVisualStyleBackColor = true;
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(27, 154);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(129, 42);
            this.btnExam.TabIndex = 2;
            this.btnExam.Text = "Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            // 
            // btnAttendence
            // 
            this.btnAttendence.Location = new System.Drawing.Point(27, 207);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(129, 42);
            this.btnAttendence.TabIndex = 3;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(27, 260);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(129, 42);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnAdmission
            // 
            this.btnAdmission.Location = new System.Drawing.Point(27, 313);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(129, 42);
            this.btnAdmission.TabIndex = 5;
            this.btnAdmission.Text = "Admission";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(27, 366);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(129, 42);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // usSideNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAdmission);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAttendence);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnHome);
            this.Name = "usSideNav";
            this.Size = new System.Drawing.Size(184, 427);
            this.Load += new System.EventHandler(this.usSideNav_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnAdmin;
    }
}
