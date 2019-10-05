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
    public partial class ucTeacher : UserControl
    {
        public ucTeacher()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPay_Click(object sender, EventArgs e)
        {

        }

        private void ucTeacher_Load(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            lblName.Hide();
            lblPay.Hide();
            txtName.Hide();
            txtPay.Hide();
            teacherBindingSource.DataSource = getTeacher();
        }

        private void ucTeacher_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                show();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblName.Show();
            lblPay.Show();
            txtName.Show();
            txtPay.Show();
          

        }
        private List<Teacher> getTeacher()
        {
            List<Teacher> teachers = new List<Teacher>();
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select name,pay from tbTeacher";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Name = reader[0].ToString();
                teacher.Pay = Convert.ToInt32(reader[1]);
                teachers.Add(teacher);
            }
            connection.Close();
            return teachers;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            addTeacher();
            teacherBindingSource.DataSource = getTeacher();
            
        }
        public void addTeacher()
        {
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "insert into tbTeacher (name,pay) values('" + txtName.Text.ToString() + "','" + Convert.ToInt32(txtPay.Text)+ "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show("Talha");

            }
        }
    }
}
