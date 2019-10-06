namespace School_Management_System
{
    partial class ucSubject
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
            this.components = new System.ComponentModel.Container();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(351, 33);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 0;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(374, 72);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 1;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(307, 99);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 20);
            this.txtSubject.TabIndex = 2;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AutoGenerateColumns = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dgvSubjects.DataSource = this.subjectBindingSource;
            this.dgvSubjects.Location = new System.Drawing.Point(199, 194);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.Size = new System.Drawing.Size(448, 195);
            this.dgvSubjects.TabIndex = 4;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellContentClick);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(257, 41);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Class";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(213, 102);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(74, 13);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject Name";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(424, 102);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(63, 13);
            this.lblMarks.TabIndex = 8;
            this.lblMarks.Text = "Total Marks";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(518, 99);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 20);
            this.txtMarks.TabIndex = 7;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(374, 146);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(School_Management_System.Subject);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            this.totalMarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // ucSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.cbClass);
            this.Name = "ucSubject";
            this.Size = new System.Drawing.Size(954, 408);
            this.Load += new System.EventHandler(this.ucSubject_Load);
            this.VisibleChanged += new System.EventHandler(this.ucSubject_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}
