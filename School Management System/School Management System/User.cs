using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    class User
    {
        string userName;
        string password;
        string joinDate;
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
        public string JoinDate { get => joinDate; set => joinDate = value; }
    }
}
