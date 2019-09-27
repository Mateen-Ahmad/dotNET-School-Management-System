using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    class Cache
    {
        public static bool isAdmin;
        public static string connection = @"Data Source=localhost\sqlexpress;Initial Catalog=dbSMS;Integrated Security=True";
        public static ucUsers ucUsers;
    }
}
