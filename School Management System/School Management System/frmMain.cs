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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ucUsers1_Load(object sender, EventArgs e)
        {

        }

        private void usSideNav1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Cache.ucUsers = ucUsers1;
            Cache.activeUC = ucUsers1;
            Cache.ucStudent = ucStudents1;
            Cache.ucStudent.Hide();
        }

        private void ucUsers1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
