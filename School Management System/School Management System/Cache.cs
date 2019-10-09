using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    class Cache
    {
        public static bool isAdmin;
        public static string connection = @"Data Source=localhost\sqlexpress;Initial Catalog=dbSMS;Integrated Security=True";
        public static UserControl activeUC;
        public static ucUsers ucUsers;
        public static ucStudents ucStudent;
        public static ucHome ucHome;
        public static ucTeacher ucTeacher;
        public static ucTeacherPay ucTeacherPay;
    }
}
