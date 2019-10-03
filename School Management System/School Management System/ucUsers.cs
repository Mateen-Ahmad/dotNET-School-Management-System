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
    public partial class ucUsers : UserControl
    {
        bool newUser;
        string oldName;
        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            show();
            txtPassword.Hide();
            txtUserName.Hide();
            lblUserName.Hide();
            lblPassword.Hide();
            btnDone.Hide();
        }

        private void show()
        {
            userBindingSource.DataSource = getUsers();
        }

        List<User> getUsers()
        {
            List<User> users = new List<User>();
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select userName,userPassword,createdDate from tbUser";
            var cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                User user = new User();
                user.UserName = reader[0].ToString();
                user.Password = reader[1].ToString();
                user.JoinDate = reader[2].ToString();
                users.Add(user);
            }
            return users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUserName.Show();
            txtPassword.Show();
            lblPassword.Show();
            lblUserName.Show();
            btnDone.Show();
            newUser = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            if(newUser)
            {
                addUser(user);
            }
            else
            {
                updateUser(oldName,user);
            }
            txtPassword.Text = "";
            txtUserName.Text = "";
            show();
            txtPassword.Hide();
            txtUserName.Hide();
            lblUserName.Hide();
            lblPassword.Hide();
            btnDone.Hide();
        }

        void addUser(User user)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "insert into tbUser (userName,userPassword,createdDate) values ('" + user.UserName + "','" + user.Password + "' , '"+DateTime.Today.ToShortDateString()+"')";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        void updateUser(string oldName, User user)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "update tbUser set userName = '" + user.UserName + "' , userPassword= '" + user.Password + "' where userName= '" + oldName + "'";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        void deleteUser(string oldName)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "delete from tbUser where userName='" + oldName + "'";
            var cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oldName = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.ColumnIndex == 3)
            {
                txtUserName.Text = oldName;
                txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUserName.Show();
                txtPassword.Show();
                lblPassword.Show();
                lblUserName.Show();
                btnDone.Show();
                newUser = false;
            }
            else if (e.ColumnIndex == 4)
            {
                deleteUser(oldName);
                show();
            }
        }

        private void ucUsers_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                show();
                txtPassword.Hide();
                txtUserName.Hide();
                lblUserName.Hide();
                lblPassword.Hide();
                btnDone.Hide();
            }
        }
    }
}
