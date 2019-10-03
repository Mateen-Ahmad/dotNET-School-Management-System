namespace School_Management_System
{
    partial class ucTeacher
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lbldgv = new System.Windows.Forms.Label();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(497, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(390, 46);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 20);
            this.txtPay.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(344, 49);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(25, 13);
            this.lblPay.TabIndex = 5;
            this.lblPay.Text = "Pay";
            this.lblPay.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // lbldgv
            // 
            this.lbldgv.AutoSize = true;
            this.lbldgv.Location = new System.Drawing.Point(303, 156);
            this.lbldgv.Name = "lbldgv";
            this.lbldgv.Size = new System.Drawing.Size(52, 13);
            this.lbldgv.TabIndex = 6;
            this.lbldgv.Text = "Teachers";
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AutoGenerateColumns = false;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.payDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dgvTeachers.DataSource = this.teacherBindingSource;
            this.dgvTeachers.Location = new System.Drawing.Point(78, 185);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.Size = new System.Drawing.Size(507, 220);
            this.dgvTeachers.TabIndex = 7;
            this.dgvTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellContentClick);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(280, 98);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(School_Management_System.Teacher);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payDataGridViewTextBoxColumn
            // 
            this.payDataGridViewTextBoxColumn.DataPropertyName = "Pay";
            this.payDataGridViewTextBoxColumn.HeaderText = "Pay";
            this.payDataGridViewTextBoxColumn.Name = "payDataGridViewTextBoxColumn";
            this.payDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ucTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.lbldgv);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.btnAdd);
            this.Name = "ucTeacher";
            this.Size = new System.Drawing.Size(717, 408);
            this.Load += new System.EventHandler(this.ucTeacher_Load);
            this.VisibleChanged += new System.EventHandler(this.ucTeacher_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lbldgv;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource teacherBindingSource;
    }
}
