using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10Class
{
    class Employee
    {
        public Employee(int empNum, string fulName)
        {
            EmployeeNum = empNum;
            FulName = fulName;
        }

        public int EmployeeNum { get; set; }
        public string FulName { get; set; }
    }
}
