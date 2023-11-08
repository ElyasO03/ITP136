using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10HW
{
    class Student : Person
    {
        public Student(int idNum, string fullName, string address, string major, string advisor)
    : base(idNum, fullName, address)
        {
            Major = major;
            Advisor = advisor;
        }

        public string Major { get; set; }
        public string Advisor { get; set; }
    }
}
