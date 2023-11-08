using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10Class
{
    class Commission : Employee
    {
        public Commission(int num, string fn, double comis) : base(num, fn)
        {
            Sales = comis;
        }

        double payAmt;

        public double Sales
        {
            get { return payAmt; }
            set { payAmt = value * 0.02; }
        }
    }
}
