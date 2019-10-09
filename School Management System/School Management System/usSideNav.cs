using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class usSideNav : UserControl
    {
        public usSideNav()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Cache.activeUC.Hide();
            Cache.ucAdmin.Show();
            Cache.activeUC = Cache.ucAdmin;
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            Cache.activeUC.Hide();
            Cache.ucStudent.Show();
            Cache.activeUC = Cache.ucStudent;
        }

        private void usSideNav_Load(object sender, EventArgs e)
        {
            if (!Cache.isAdmin)
            {
                btnAdmin.Hide();
            }
            else btnAdmin.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Cache.activeUC.Hide();
            Cache.ucHome.Show();
            Cache.activeUC = Cache.ucHome;
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Cache.activeUC.Hide();
            Cache.ucTeacherPay.Show();
            Cache.activeUC = Cache.ucTeacherPay;
        }
    }
}
