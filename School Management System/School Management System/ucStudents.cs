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

namespace School_Management_System
{
    public partial class ucStudents : UserControl
    {
        string rollno;
        bool isNewStudent;
        public ucStudents()
        {
            InitializeComponent();
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            show();
            lblRollNumber.Hide();
            lblName.Hide();
            lblFatherName.Hide();
            lblPhoneNumber.Hide();
            lblEmail.Hide();
            lblClass.Hide();
            txtRollNumber.Hide();
            txtName.Hide();
            txtFatherName.Hide();
            txtPhoneNumber.Hide();
            txtEmail.Hide();
            cmbClass.Hide();
            btnSave.Hide();
            btnAdd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblRollNumber.Show();
            lblName.Show();
            lblFatherName.Show();
            lblPhoneNumber.Show();
            lblEmail.Show();
            lblClass.Show();
            txtRollNumber.Show();
            txtName.Show();
            txtFatherName.Show();
            txtPhoneNumber.Show();
            txtEmail.Show();
            cmbClass.Show();
            btnSave.Show();
            btnAdd.Hide();
            isNewStudent = true;
        }


        List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select rollNumber,name,fatherName,phoneNumber,email,class,createdBy,createdDate from tbStudent";
            var cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.RollNumber = reader[0].ToString();
                student.Name = reader[1].ToString();
                student.FatherName = reader[2].ToString();
                student.PhoneNumber = reader[3].ToString();
                student.Email = reader[4].ToString();
                student.Class1 = reader[5].ToString();
                student.CreatedBy = reader[6].ToString();
                student.CreatedDate = reader[7].ToString();
                students.Add(student);
            }
            return students;
        }
        private void show()
        {
            studentBindingSource.DataSource = getStudents();
        }

        void addStudent(Student student)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "insert into tbStudent (rollNumber,name,fatherName,phoneNumber,email,class,createdBy,createdDate) values ('" + student.RollNumber + "','" + student.Name + "', '" + student.FatherName + "', '" + student.PhoneNumber + "', '" + student.Email + "', '" + student.Class1 + "', '" + student.CreatedBy + "', '" + student.CreatedDate + "')";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        void deleteStudent(string rollno)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "delete from tbStudent where rollNumber='" + rollno + "'";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        void updateStudent(string rollno, Student student)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "update tbStudent set rollNumber ='" + student.RollNumber + "' , name = '" + student.Name + "', fatherName= '" + student.FatherName + "', phoneNumber = '" + student.PhoneNumber + "', email = '" + student.Email + "', class = '" + student.Class1 + "' where rollnumber= '" + rollno + "'";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rollno = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.ColumnIndex == 8)
            {
                txtRollNumber.Text = rollno;
                txtName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtFatherName.Text = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhoneNumber.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbClass.Text = dgvStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblRollNumber.Show();
                lblName.Show();
                lblFatherName.Show();
                lblPhoneNumber.Show();
                lblEmail.Show();
                lblClass.Show();
                txtRollNumber.Show();
                txtName.Show();
                txtFatherName.Show();
                txtPhoneNumber.Show();
                txtEmail.Show();
                cmbClass.Show();
                btnSave.Show();
                btnAdd.Hide();
                isNewStudent = false;
            }
            else if (e.ColumnIndex == 9)
            {
                deleteStudent(rollno);
                show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.RollNumber = txtRollNumber.Text;
            student.Name = txtName.Text;
            student.FatherName = txtFatherName.Text;
            student.PhoneNumber = txtPhoneNumber.Text;
            student.Email = txtEmail.Text;
            student.Class1 = cmbClass.SelectedItem.ToString();
            student.CreatedBy = "Mateen";
            student.CreatedDate = DateTime.Today.ToShortDateString();
            if (isNewStudent)
            {
                addStudent(student);
            }
            else
            {
                updateStudent(rollno, student);
            }
            txtRollNumber.Text = "";
            txtName.Text = "";
            txtFatherName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            cmbClass.SelectedItem = null;

            lblRollNumber.Hide();
            lblName.Hide();
            lblFatherName.Hide();
            lblPhoneNumber.Hide();
            lblEmail.Hide();
            lblClass.Hide();
            txtRollNumber.Hide();
            txtName.Hide();
            txtFatherName.Hide();
            txtPhoneNumber.Hide();
            txtEmail.Hide();
            cmbClass.Hide();
            btnSave.Hide();
            btnAdd.Show();

            show();
        }
    }
}
