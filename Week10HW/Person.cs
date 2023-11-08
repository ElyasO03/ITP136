using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10HW
{
    class Person
    {
        public Person(int idNum, string fullName, string address)
        {
            IdNum = idNum;
            FullName = fullName;
            Address = address;
        }

        public int IdNum { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
