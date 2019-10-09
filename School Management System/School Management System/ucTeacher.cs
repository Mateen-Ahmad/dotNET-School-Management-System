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
        bool newTeacher = false;
        string teacherName;
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
            lblName.Hide();
            lblPay.Hide();
            txtName.Hide();
            txtPay.Hide();
            btnDone.Hide();
            show();
        }

        private void show()
        {
           
            teacherBindingSource.DataSource = getTeacher();
        }

        private void ucTeacher_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                lblName.Hide();
                lblPay.Hide();
                txtName.Hide();
                txtPay.Hide();
                btnDone.Hide();
                show();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblName.Show();
            lblPay.Show();
            txtName.Show();
            txtPay.Show();
            btnDone.Show();
            newTeacher = true;

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
            if(ValidateChildren())
            {
                if (Valid(txtName.Text))
                {
                    Teacher teacher = new Teacher();
                    teacher.Name = txtName.Text;
                    teacher.Pay = Convert.ToInt32(txtPay.Text);
                    if (newTeacher)
                    {
                        addTeacher(teacher);
                        teacherBindingSource.DataSource = getTeacher();
                        show();
                    }
                    else
                    {
                        updateTeacher(teacher);
                        show();
                    }
                    txtName.Text = "";
                    txtPay.Text = "";
                    txtName.Hide();
                    txtPay.Hide();
                    lblName.Hide();
                    lblPay.Hide();
                    btnDone.Hide();
                }
                else
                {
                    MessageBox.Show("This name is already exist");
                }
            }
            
            
        }
        private void addTeacher(Teacher teacher)
        {
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "insert into tbTeacher (name,pay) values('" + teacher.Name + "','" + teacher.Pay+ "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex==2)
            {
                teacherName = dgvTeachers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = teacherName;
                txtPay.Text = dgvTeachers.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblName.Show();
                lblPay.Show();
                txtName.Show();
                txtPay.Show();
                btnDone.Show();
            }
            else if(e.ColumnIndex==3)
            {
                teacherName = dgvTeachers.Rows[e.RowIndex].Cells[0].Value.ToString();
                deleteTeacher(teacherName);
                show();
            }
        }
        private void updateTeacher(Teacher teacher)
        {
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "update tbTeacher set name= '" + teacher.Name + "', pay ='" + teacher.Pay + "' where name= '" + teacherName + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private void deleteTeacher(string teacher)
        {
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "delete from tbTeacher where name ='" + teacher + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private bool Valid(string name)
        {
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select count (*) from tbTeacher where name= '" + name + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            var count = cmd.ExecuteScalar();
            if(Convert.ToInt32(count)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "Please Enter Name");
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }
        }

        private void txtPay_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPay.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPay, "Please Enter Pay");
            }
            else
            {
                errorProvider1.SetError(txtPay, null);
            }
        }
    }
}
