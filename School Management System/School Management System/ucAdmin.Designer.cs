namespace School_Management_System
{
    partial class ucAdmin
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
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.ucSubject1 = new School_Management_System.ucSubject();
            this.ucUsers1 = new School_Management_System.ucUsers();
            this.ucClass1 = new School_Management_System.ucClass();
            this.ucTeacher1 = new School_Management_System.ucTeacher();
            this.SuspendLayout();
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(64, 13);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(106, 27);
            this.btnTeacher.TabIndex = 0;
            this.btnTeacher.Text = "Teachers";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(225, 17);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(106, 23);
            this.btnSubject.TabIndex = 1;
            this.btnSubject.Text = "Subjects";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(386, 15);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(106, 23);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Classes";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(547, 15);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(106, 25);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // ucSubject1
            // 
            this.ucSubject1.Location = new System.Drawing.Point(76, 60);
            this.ucSubject1.Name = "ucSubject1";
            this.ucSubject1.Size = new System.Drawing.Size(542, 408);
            this.ucSubject1.TabIndex = 5;
            // 
            // ucUsers1
            // 
            this.ucUsers1.Location = new System.Drawing.Point(19, 62);
            this.ucUsers1.Name = "ucUsers1";
            this.ucUsers1.Size = new System.Drawing.Size(687, 429);
            this.ucUsers1.TabIndex = 4;
            // 
            // ucClass1
            // 
            this.ucClass1.Location = new System.Drawing.Point(94, 60);
            this.ucClass1.Name = "ucClass1";
            this.ucClass1.Size = new System.Drawing.Size(524, 424);
            this.ucClass1.TabIndex = 6;
            // 
            // ucTeacher1
            // 
            this.ucTeacher1.Location = new System.Drawing.Point(29, 46);
            this.ucTeacher1.Name = "ucTeacher1";
            this.ucTeacher1.Size = new System.Drawing.Size(717, 408);
            this.ucTeacher1.TabIndex = 7;
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucTeacher1);
            this.Controls.Add(this.ucClass1);
            this.Controls.Add(this.ucSubject1);
            this.Controls.Add(this.ucUsers1);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnTeacher);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(791, 471);
            this.Load += new System.EventHandler(this.ucAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnUsers;
        private ucUsers ucUsers1;
        private ucSubject ucSubject1;
        private ucClass ucClass1;
        private ucTeacher ucTeacher1;
    }
}
