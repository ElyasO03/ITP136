using System;
using static System.Console;

namespace Week5HW
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeStatement();

            int secretNumber = 1;
            MagicNumber(secretNumber);

            int a, b;

            for(int k=0; k < 1; k ++)
            {
                a = asknumber();
                b = asknumber();

                multiplynumber(a, b);
            }

            double taxRate = localTaxRate();
            WriteLine("Your local tax rate is " + taxRate + "%");


            ReadKey();
        }

    static void WelcomeStatement()
        {
            WriteLine("Welcome to My Method Examples");
        }

    static void MagicNumber(int secretNumber)
        {
            WriteLine("The magic number is " + secretNumber);
        }

    static int asknumber()
        {
            int x;
            WriteLine("Enter a number");
            x = Convert.ToInt32(ReadLine());

            return x;
        }

    static void multiplynumber(int num1, int num2)
        {
            int total = num1 * num2;

            WriteLine("Your total is {0}", total);
        }

    static double localTaxRate()
        {
            WriteLine("Please enter your local tax rate ");
            string input = ReadLine();

            return Convert.ToDouble(input);
        }

    }
}
