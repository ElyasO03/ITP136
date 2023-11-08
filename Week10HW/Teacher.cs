using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10HW
{
    class Teacher : Person
    {
        public Teacher(int idNum, string fullName, string address, double salary, int yearsOfService)
    : base(idNum, fullName, address)
        {
            Salary = salary;
            YearsOfService = yearsOfService;
        }

        public double Salary { get; set; }
        public int YearsOfService { get; set; }
    }
}
