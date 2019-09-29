using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    class Student
    {
        private string rollNumber;
        private string name;
        private string fatherName;
        private string phoneNumber;
        private string email;
        private string Class;
        private string createdBy;
        private string createdDate;

        public string RollNumber { get => rollNumber; set => rollNumber = value; }
        public string Name { get => name; set => name = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Class1 { get => Class; set => Class = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public string CreatedDate { get => createdDate; set => createdDate = value; }
    }
}
