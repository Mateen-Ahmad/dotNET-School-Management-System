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
            show();
        }

        private void show()
        {
            teacherBindingSource.DataSource = getTeachers();
        }

        private List<Teacher> getTeachers()
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
    }
}
