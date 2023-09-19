using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4Class
{
    public class Employee
    {
            int empId;
            string fName, lName;

        public int EmployeeId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string LastName
        {
            get { return lName;  }
            set { lName = value; }
        }

        public string FirstName
        {
            get { return fName;  }
            set { fName = value; }
        }

        }
    }
