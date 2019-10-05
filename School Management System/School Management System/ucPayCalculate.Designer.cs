namespace School_Management_System
{
    partial class ucPayCalculate
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
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblCalculatePay = new System.Windows.Forms.Label();
            this.txtCalculatedPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPay
            // 
            this.txtPay.Enabled = false;
            this.txtPay.Location = new System.Drawing.Point(184, 28);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(237, 20);
            this.txtPay.TabIndex = 0;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(100, 34);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(25, 13);
            this.lblPay.TabIndex = 1;
            this.lblPay.Text = "Pay";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(184, 55);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(237, 20);
            this.txtAdvance.TabIndex = 2;
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Location = new System.Drawing.Point(100, 62);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(50, 13);
            this.lblAdvance.TabIndex = 3;
            this.lblAdvance.Text = "Advance";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(100, 87);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Month";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(184, 81);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(237, 21);
            this.cbMonth.TabIndex = 6;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AccessibleName = "lblAttendance";
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(100, 114);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(62, 13);
            this.lblAttendance.TabIndex = 8;
            this.lblAttendance.Text = "Attendance";
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(184, 107);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(237, 20);
            this.txtAttendance.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(229, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Pay";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(229, 207);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(101, 23);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblCalculatePay
            // 
            this.lblCalculatePay.AccessibleName = "lblAttendance";
            this.lblCalculatePay.AutoSize = true;
            this.lblCalculatePay.Location = new System.Drawing.Point(100, 169);
            this.lblCalculatePay.Name = "lblCalculatePay";
            this.lblCalculatePay.Size = new System.Drawing.Size(72, 13);
            this.lblCalculatePay.TabIndex = 12;
            this.lblCalculatePay.Text = "Calulated Pay";
            // 
            // txtCalculatedPay
            // 
            this.txtCalculatedPay.Location = new System.Drawing.Point(184, 162);
            this.txtCalculatedPay.Name = "txtCalculatedPay";
            this.txtCalculatedPay.Size = new System.Drawing.Size(237, 20);
            this.txtCalculatedPay.TabIndex = 11;
            // 
            // ucPayCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCalculatePay);
            this.Controls.Add(this.txtCalculatedPay);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.txtPay);
            this.Name = "ucPayCalculate";
            this.Size = new System.Drawing.Size(590, 268);
            this.Load += new System.EventHandler(this.ucPayCalculate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblCalculatePay;
        private System.Windows.Forms.TextBox txtCalculatedPay;
    }
}
