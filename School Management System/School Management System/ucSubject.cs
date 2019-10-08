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
    public partial class ucSubject : UserControl
    {
        List<Class> classes = new List<Class>();
        int selectedClassIndex;
        bool edit;
        string oldName;
        public ucSubject()
        {
            InitializeComponent();
        }

        private void ucSubject_Load(object sender, EventArgs e)
        {
            lblMarks.Hide();
            lblSubject.Hide();
            txtMarks.Hide();
            txtSubject.Hide();
            btnDone.Hide();
            btnAddSubject.Hide();
            dgvSubjects.Hide();
        }

        private void ucSubject_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                cbClass.SelectedIndex = -1;
                cbClass.Items.Clear();
                load();
            }
        }
        void load()
        {
            classes = getClasses();
            for (int i = 0; i < classes.Count; i++)
            {
                cbClass.Items.Add(classes[i].ClassName);
            }
        }
        void show()
        {
            subjectBindingSource.DataSource = getSubjects(selectedClassIndex);
        }
        List<Subject> getSubjects(int classindex)
        {
            List<Subject> subjects = new List<Subject>();
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select name,totalMarks from tbSubject where classIndex='" + classindex + "'";
            var cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Subject subject = new Subject();
                subject.Name = reader[0].ToString();
                subject.TotalMarks = Convert.ToInt32(reader[1]);
                subjects.Add(subject);
            }
            reader.Close();
            connection.Close();
            return subjects;
        }
        List<Class>getClasses()
        {
            List<Class> @classes = new List<Class>();
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select [index],class from tbClass";
            var cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Class c = new Class();
                c.Index = Convert.ToInt32(reader[0]);
                c.ClassName = reader[1].ToString();
                @classes.Add(c);
            }
            reader.Close();
            connection.Close();
            return @classes;
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClass.SelectedIndex!=-1)
            {
                selectedClassIndex = classes[cbClass.SelectedIndex].Index;
                btnAddSubject.Show();
                dgvSubjects.Show();
                show();
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            lblMarks.Show();
            lblSubject.Show();
            txtMarks.Show();
            txtSubject.Show();
            btnDone.Show();
            btnAddSubject.Hide();
            edit = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.Name = txtSubject.Text;
            subject.TotalMarks = Convert.ToInt32(txtMarks.Text);
            if(edit)
            {
                updateSubject(subject, oldName, selectedClassIndex);
            }
            else
            {
                addSubject(subject, selectedClassIndex);
            }

            lblMarks.Hide();
            lblSubject.Hide();
            txtMarks.Hide();
            txtSubject.Hide();
            btnDone.Hide();
            btnAddSubject.Show();
            show();
        }
        void updateSubject(Subject subject, string oldName, int classIndex)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "update tbSubject set name = '" + subject.Name + "' and totalMarks = '" + subject.TotalMarks + "'where name = '"+oldName+"' and classIndex='" + classIndex + "')";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        void addSubject(Subject subject, int classIndex)
        {
            List<Subject> subjects = new List<Subject>();
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "insert into tbSubject (name,totalMarks,classIndex) values ('" + subject.Name + "' , '" + subject.TotalMarks + "', '" + classIndex + "')";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string oldName = dgvSubjects.Rows[e.RowIndex].Cells[0].Value.ToString();
            if(e.ColumnIndex==2)
            {
                edit = true;
                txtSubject.Text = oldName;
                txtMarks.Text = dgvSubjects.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblMarks.Show();
                lblSubject.Show();
                txtMarks.Show();
                txtSubject.Show();
                btnDone.Show();
                btnAddSubject.Hide();
            }
            if(e.ColumnIndex==3)
            {
                deleteSubject(oldName, selectedClassIndex);
                show();
            }
        }
        void deleteSubject(string name, int classIndex)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "delete from tbSubject where name='" + name + "' and classIndex='" + classIndex + "'";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
