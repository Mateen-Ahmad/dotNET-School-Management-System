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
    public partial class ucClass : UserControl
    {
        bool edit;
        string oldName;
        public ucClass()
        {
            InitializeComponent();
        }

        private void ucClass_Load(object sender, EventArgs e)
        {
            lblClassName.Hide();
            txtClassName.Hide();
            btnDone.Hide();
        }

        private void ucClass_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                show();
            }
        }
        void show()
        {
            classBindingSource.DataSource = GetClasses();
        }
        List<Class> GetClasses()
        {
            List<Class> classes = new List<Class>();
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select class from tbClass";
            var cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Class c = new Class();
                c.ClassName = reader[0].ToString();
                classes.Add(c);
            }
            reader.Close();
            connection.Close();
            return classes;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            btnDone.Show();
            lblClassName.Show();
            txtClassName.Show();
            btnAddClass.Hide();
            edit = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Class c = new Class();
            c.ClassName = txtClassName.Text;
            if(edit)
            {
                updateClass(c, oldName);
            }
            else
            {
                addClass(c);
            }
            lblClassName.Hide();
            txtClassName.Hide();
            btnDone.Hide();
            btnAddClass.Show();
            show();
        }
        void updateClass(Class c, string oldName)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "update tbClass set class = '" + c.ClassName + "' where class='" + oldName + "'";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        void addClass(Class c)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "insert into tbClass (class) values ('" + c.ClassName + "')";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            
        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string className = dgvClasses.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.ColumnIndex==1)
            {
                edit = true;
                txtClassName.Text = className ;
                btnAddClass.Hide();
                btnDone.Show();
                lblClassName.Show();
                txtClassName.Show();
                oldName = className;
            }
            else if(e.ColumnIndex==2)
            {
                deleteClass(className);
                show();
            }
        }
        void deleteClass(string className)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "delete from tbClass where class= '" + className + "'";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
