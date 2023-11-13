using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Week11Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberArray = { "Gretzky", "Jordan", "Pippin" };

            try
            {
                WriteLine("Please enter the element you wish to see");

                int elementNumber = Convert.ToInt32(ReadLine());


                WriteLine(numberArray[elementNumber]);
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine("Don't enter a number larger than 2" + "\nERROR: " + e);
            }








            int num1, num2;

            WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(ReadLine());

            double total;

            try
            {
                total = num1 / num2;
                WriteLine("Your total is " + total);
            }
            catch(DivideByZeroException e)
            {
                WriteLine("Sorry you entered zero for your second number, don't to that" + "\nERROR: " + e);
            }

            ReadKey();

        }
    }
}
