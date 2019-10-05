namespace School_Management_System
{
    partial class ucTeacherPay
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
            this.dgvTeacherPay = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPayCalculate1 = new School_Management_System.ucPayCalculate();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.calculatedPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherPay
            // 
            this.dgvTeacherPay.AllowUserToAddRows = false;
            this.dgvTeacherPay.AllowUserToDeleteRows = false;
            this.dgvTeacherPay.AutoGenerateColumns = false;
            this.dgvTeacherPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.payDataGridViewTextBoxColumn,
            this.calculate,
            this.calculatedPayDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn});
            this.dgvTeacherPay.DataSource = this.teacherBindingSource;
            this.dgvTeacherPay.Location = new System.Drawing.Point(3, 255);
            this.dgvTeacherPay.Name = "dgvTeacherPay";
            this.dgvTeacherPay.ReadOnly = true;
            this.dgvTeacherPay.Size = new System.Drawing.Size(711, 150);
            this.dgvTeacherPay.TabIndex = 0;
            this.dgvTeacherPay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherPay_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ucPayCalculate1
            // 
            this.ucPayCalculate1.Advance = 0;
            this.ucPayCalculate1.Attendance = 0;
            this.ucPayCalculate1.Index = 0;
            this.ucPayCalculate1.Location = new System.Drawing.Point(35, 0);
            this.ucPayCalculate1.Name = "ucPayCalculate1";
            this.ucPayCalculate1.Pay = 0;
            this.ucPayCalculate1.Size = new System.Drawing.Size(643, 249);
            this.ucPayCalculate1.TabIndex = 1;
            this.ucPayCalculate1.Load += new System.EventHandler(this.load_payCalculate);
            this.ucPayCalculate1.VisibleChanged += new System.EventHandler(this.ucPayCalculate1_VisibleChanged);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(School_Management_System.Teacher);
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
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
            // calculate
            // 
            this.calculate.HeaderText = "Calculate";
            this.calculate.Name = "calculate";
            this.calculate.ReadOnly = true;
            this.calculate.Text = "Calculate Pay";
            // 
            // calculatedPayDataGridViewTextBoxColumn
            // 
            this.calculatedPayDataGridViewTextBoxColumn.DataPropertyName = "CalculatedPay";
            this.calculatedPayDataGridViewTextBoxColumn.HeaderText = "CalculatedPay";
            this.calculatedPayDataGridViewTextBoxColumn.Name = "calculatedPayDataGridViewTextBoxColumn";
            this.calculatedPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucTeacherPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPayCalculate1);
            this.Controls.Add(this.dgvTeacherPay);
            this.Name = "ucTeacherPay";
            this.Size = new System.Drawing.Size(717, 408);
            this.Load += new System.EventHandler(this.ucTeacherPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacherPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private ucPayCalculate ucPayCalculate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn calculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
    }
}
