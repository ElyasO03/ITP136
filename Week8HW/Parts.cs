using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Week8HW
{
    class Parts
    {
        int partNum;
        string partName, partDescription;
        double cost;

        public Parts(int partNum, string partName, string partDescription, double cost)
        {
            this.partNum = partNum;
            this.partName = partName;
            this.partDescription = partDescription;
            this.cost = cost;
        }

        public int PartNum
        {
            get { return partNum; }
            set { partNum = value; }
        }

        public string PartName
        {
            get { return partName; }
            set { partName = value; }
        }

        public string PartDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
