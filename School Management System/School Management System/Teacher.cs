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
        string month;
        public Teacher()
        {

        }
        public Teacher(Teacher teacher)
        {
            index = teacher.index;
            name = teacher.name;
            pay = teacher.pay;
            calculatedPay = teacher.calculatedPay;
            month = teacher.month;
        }
        public string Name { get => name; set => name = value; }
        public int Pay { get => pay; set => pay = value; }
        public int Index { get => index; set => index = value; }
        public int CalculatedPay { get => calculatedPay; set => calculatedPay = value; }
        public string Month { get => month; set => month = value; }
    }
}
