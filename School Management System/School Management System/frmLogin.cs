using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            bool login;
            // This is to be moved to wcf
            if(Cache.isAdmin)
            {
                login = loginAdmin(user);
            }
            else
            {
                login = loginUser(user);
            }
            // 
            if(login)
            {
                ActiveForm.Close();
                (new frmMain()).Show();
            }
        }
        bool loginAdmin(User user)
        {
            if(user.UserName=="1" && user.Password=="1")
            {
                return true;
            }
            return false;
        }
        bool loginUser(User user)
        {
            var connection = new SqlConnection(Cache.connection);
            connection.Open();
            string query = "select count * from tbUser where userName='" + user.UserName + "' and userPassword='" + user.Password + "'";
            var cmd = new SqlCommand(query, connection);
            var count = cmd.ExecuteScalar();
            connection.Close();
            if(Convert.ToInt32(count)==0)
            {
                return false;
            }
            return true;
        }
    }
}
