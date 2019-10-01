namespace School_Management_System
{
    partial class ucHome
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
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.dgvHome = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(22, 31);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(147, 43);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.Location = new System.Drawing.Point(254, 31);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(147, 43);
            this.btnClasses.TabIndex = 1;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(483, 31);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(147, 43);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // dgvHome
            // 
            this.dgvHome.AllowUserToAddRows = false;
            this.dgvHome.AllowUserToDeleteRows = false;
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.Location = new System.Drawing.Point(22, 146);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.ReadOnly = true;
            this.dgvHome.Size = new System.Drawing.Size(608, 150);
            this.dgvHome.TabIndex = 3;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHome);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.btnStudents);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(730, 356);
            this.Load += new System.EventHandler(this.ucHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.DataGridView dgvHome;
    }
}
