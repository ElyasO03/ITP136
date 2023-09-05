using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Vehicle Maintenance Calculator App");

            double oilchange, tires, inspection;

            double total;

            double tax;

            double cost;

            string inputString;

            Console.WriteLine("Please enter oil change cost?");
            inputString = Console.ReadLine();

            oilchange = Convert.ToDouble(inputString);

            Console.WriteLine("Please enter tire cost? ");
            inputString = Console.ReadLine();

            tires = Convert.ToDouble(inputString);

            Console.WriteLine("Please enter inspection cost? ");
            inputString = Console.ReadLine();

            inspection = Convert.ToDouble(inputString);

            tax = (oilchange + tires + inspection) * 0.06;

            cost = oilchange + tires + inspection;

            total = cost + tax;

            Console.WriteLine("Your total maintenance cost plus tax is {0}", total.ToString("C"));

            Console.ReadKey();
        }
    }
}
