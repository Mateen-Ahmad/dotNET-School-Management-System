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
            Cache.ucSubject.Show();
            Cache.activeUC = Cache.ucSubject;
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            Cache.activeUC.Hide();
            Cache.ucTeacher.Show();
            Cache.activeUC = Cache.ucClass;
            
        }

        private void usSideNav_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Cache.activeUC.Hide();
            Cache.ucHome.Show();
            Cache.activeUC = Cache.ucHome;
            
        }
    }
}
