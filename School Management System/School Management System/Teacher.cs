using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    class Teacher
    {
        int index;
        string name;
        int pay;
        int calculatedPay;
        int month;
       
        public string Name { get => name; set => name = value; }
        public int Pay { get => pay; set => pay = value; }
        public int Index { get => index; set => index = value; }
        public int CalculatedPay { get => calculatedPay; set => calculatedPay = value; }
        public int Month { get => month; set => month = value; }
    }
}
