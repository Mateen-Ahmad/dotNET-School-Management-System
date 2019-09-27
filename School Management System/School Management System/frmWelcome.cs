using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Cache.isAdmin = true;
            ActiveForm.Hide();
            (new frmLogin()).Show();
           
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Cache.isAdmin = false;
            ActiveForm.Hide();
            (new frmLogin()).Show();
            
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
