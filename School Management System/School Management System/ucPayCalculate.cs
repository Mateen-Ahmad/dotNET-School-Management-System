using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace School_Management_System
{
    public partial class ucPayCalculate : UserControl
    {
        int pay;
        int totalPay;
        int attendance;
        int advance;
        int index;
        public ucPayCalculate()
        {
            InitializeComponent();
            pay = attendance = advance = totalPay = 0;
        }

        public int Pay { get => pay; set => pay = value; }
        public int Attendance { get => attendance; set => attendance = value; }
        public int Advance { get => advance; set => advance = value; }
        public int Index { get => index; set => index = value; }

        private void ucPayCalculate_Load(object sender, EventArgs e)
        {
             
        }

        public void show()
        {
            MessageBox.Show("Talha");
            this.Show();
            txtPay.Text = Pay.ToString();
            txtMonth.Text = DateTime.Today.ToString("MMMM");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            attendance = int.Parse(txtAttendance.Text);
            advance = int.Parse(txtAdvance.Text);
            txtCalculatedPay.Text = calculatePay(attendance,advance).ToString();
        }

        public int calculatePay(int attendance,int advance)
        {
            var perDayPay = pay / 30;
            totalPay = perDayPay * attendance;
            totalPay = totalPay - advance;
            return totalPay;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            DateTime dateTime = DateTime.UtcNow.Date;
            addTeacherPay(this.index, month, this.totalPay, false, dateTime);
            this.Hide();
        }

        private void addTeacherPay(int index, string month, int pay, bool recived, DateTime date)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "insert into tbPayRecord (teacherIndex,month,calculatedPay,received,date) values ('" + index + "','" + month + "', '" +pay + "', '" + recived + "', '" + date + "')";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
