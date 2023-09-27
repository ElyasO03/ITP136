using System;
using static System.Console;

namespace Week5Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            
            welcomeMessage();

            for(int k= 0; k < 3; k ++)
            {
                a = askNumber();
                b = askNumber();

                addNumber(a, b);
            }

            ReadKey();

        }

        static void welcomeMessage()
        {
            WriteLine("Welcome to my method");
        }

        static int askNumber()
        {
            int x;
            WriteLine("Enter a number");
            x = Convert.ToInt32(ReadLine());

            return x;
        }

        static void addNumber(int num1, int num2)
        {
            int total = num1 + num2;

            WriteLine("Your tatal is {0}", total);
        }
    }
}
