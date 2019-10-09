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
            dgvTeacherPay.Rows.Clear();
            List<Teacher> teachers=showTeacherRecord();
            for (int i=0; i<teachers.Count;i++)
            {
                dgvTeacherPay.Rows.Add(teachers[i].Index, teachers[i].Name, teachers[i].Pay, "Calculate", teachers[i].Month, teachers[i].CalculatedPay);
            }
        }

        private List<Teacher> showTeacherRecord()
        {
            List<Teacher> teachers = new List<Teacher>();
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select [index],name,pay from tbTeacher";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Index =Convert.ToInt32(reader[0]);
                teacher.Name = reader[1].ToString();
                teacher.Pay = Convert.ToInt32(reader[2]);
                teacher.Month = "none";
                teacher.CalculatedPay = 0;
                teachers.Add(teacher);
            }
            reader.Close();
            var month = DateTime.Today.ToString("MMMM");
            for (int i=0; i<teachers.Count;i++)
            {
                query = "select month,calculatedPay from tbPayRecord where teacherIndex='" + teachers[i].Index + "' ";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(reader[0].ToString()==month)
                    {
                        teachers[i].Month = month;
                        teachers[i].CalculatedPay = Convert.ToInt32(reader[1]);
                    }
                }
                reader.Close();
            }
            return teachers;
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
            if(!ucPayCalculate1.Visible)
            {
                show();
            }
        }

        private void ucTeacherPay_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                show();
            }
        }
    }
}
