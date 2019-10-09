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
    public partial class ucAdmin : UserControl
    {
        UserControl activeUC;
        public ucAdmin()
        {
            InitializeComponent();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            activeUC.Hide();
            ucTeacher1.Show();
            activeUC = ucTeacher1;
        }

        private void ucAdmin_Load(object sender, EventArgs e)
        {
            ucSubject1.Hide();
            ucTeacher1.Hide();
            ucClass1.Hide();
            activeUC = ucUsers1;
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            activeUC.Hide();
            ucSubject1.Show();
            activeUC = ucSubject1;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            activeUC.Hide();
            ucClass1.Show();
            activeUC = ucClass1;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            activeUC.Hide();
            ucUsers1.Show();
            activeUC = ucUsers1;
        }
    }
}
