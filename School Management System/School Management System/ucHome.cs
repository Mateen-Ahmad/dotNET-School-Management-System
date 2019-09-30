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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            dgvHome.DataSource=getStudents();
        }
        List <Student> getStudents()
        {
            List<Student> students = new List<Student>();
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select name,class from tbStudent";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.Name = reader[0].ToString();
                student.Class1 = reader[1].ToString();
                students.Add(student);
            }
            connection.Close();
            return students;
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            dgvHome.DataSource=getClass();
        }
        List<Class> getClass()
        {
            List<Class> classes = new List<Class>();
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select class from tbClass";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Class classs = new Class();
                classs.Clas = reader[0].ToString();
                classes.Add(classs);
            }
            return classes;
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            dgvHome.DataSource=getEmployes();
        }
        List<Employ> getEmployes()
        {
            List<Employ> employs = new List<Employ>();
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select name,pay from tbTeacher";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employ employ = new Employ();
                employ.Name = reader[0].ToString();
                employ.Pay = Convert.ToInt32(reader[1]);
                employs.Add(employ);
            }
            return employs;
        }
    }
}
