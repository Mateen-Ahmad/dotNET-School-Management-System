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
            this.dgvTeacherPay = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPayCalculate1 = new School_Management_System.ucPayCalculate();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherPay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherPay
            // 
            this.dgvTeacherPay.AllowUserToAddRows = false;
            this.dgvTeacherPay.AllowUserToDeleteRows = false;
            this.dgvTeacherPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.calculate,
            this.Column4,
            this.Column5});
            this.dgvTeacherPay.Location = new System.Drawing.Point(3, 255);
            this.dgvTeacherPay.Name = "dgvTeacherPay";
            this.dgvTeacherPay.ReadOnly = true;
            this.dgvTeacherPay.Size = new System.Drawing.Size(711, 150);
            this.dgvTeacherPay.TabIndex = 0;
            this.dgvTeacherPay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherPay_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Index";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pay";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // calculate
            // 
            this.calculate.HeaderText = "Calculate";
            this.calculate.Name = "calculate";
            this.calculate.ReadOnly = true;
            this.calculate.Text = "Calculate Pay";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Month";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Calculated Pay";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
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
            // ucTeacherPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPayCalculate1);
            this.Controls.Add(this.dgvTeacherPay);
            this.Name = "ucTeacherPay";
            this.Size = new System.Drawing.Size(717, 408);
            this.Load += new System.EventHandler(this.ucTeacherPay_Load);
            this.VisibleChanged += new System.EventHandler(this.ucTeacherPay_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacherPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ucPayCalculate ucPayCalculate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn calculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
