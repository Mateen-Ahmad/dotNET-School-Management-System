using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    
    public partial class ucTeacherPay : UserControl
    {
        public ucTeacherPay()
        {
            InitializeComponent();
        }

        private void ucTeacherPay_Load(object sender, EventArgs e)
        {
            ucPayCalculate1.Hide();
            show();
        }

        private void show()
        {
            showTeacherRecord();
        }

        private void showTeacherRecord()
        {
            List<Teacher> teachers = new List<Teacher>();
            SqlConnection connection = new SqlConnection(Cache.connection);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText= "select [index],name,pay from tbTeacher";
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dgvTeacherPay.DataSource = ds.Tables[0].DefaultView;
        }


        private void dgvTeacherPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ucPayCalculate1.Pay = (int)dgvTeacherPay[2, e.RowIndex].Value;
                ucPayCalculate1.Index = (int)dgvTeacherPay[0, e.RowIndex].Value;
                ucPayCalculate1.show();
            }
        }

        private void load_payCalculate(object sender, EventArgs e)
        {

        }

        private void ucPayCalculate1_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
