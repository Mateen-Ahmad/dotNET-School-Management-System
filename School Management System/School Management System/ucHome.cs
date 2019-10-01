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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            List<Student> students = getStudents();
            table.Columns.Add("Name");
            table.Columns.Add("Class");
            for (int i = 0; i < students.Count; i++)
            {
                table.Rows.Add(students[i].Name, students[i].Class1);
            }
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dgvHome.DataSource = source;
        }
        private void btnClasses_Click(object sender, EventArgs e)
        {
            
            BindingSource source = new BindingSource();
            source.DataSource = getClass();
            dgvHome.DataSource = source;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = getEmployes();
            dgvHome.DataSource = source;
        }
        List<Class> getClass()
        {
            List<Class> classes = new List<Class>();
            SqlConnection connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select class from tbClass";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Class classs = new Class();
                classs.ClassName = reader[0].ToString();
                classes.Add(classs);
            }
            return classes;
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
        List<Student> getStudents()
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
    }
}

