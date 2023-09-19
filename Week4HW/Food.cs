using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4HW
{
    public class Food
    {
        int foodID;
        string name, description;
        double cost;

        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        public string fname
        {
            get { return name; }
            set { name = value; }
        }

        public string fdescription
        {
            get { return description; }
            set { description = value; }
        }

        public double fcost
        {
            get { return cost; }
            set { cost = value;}
        }
    }
}
