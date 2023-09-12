using System;
using static System.Console;

namespace Week3Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 3;

            if (first == second)
            {
                WriteLine("First equals second");
            }
            else
            {
                if (first > second)
                {
                    WriteLine("First is greater than second");
                }
                else
                {
                    WriteLine("First is less than second");
                }
            }



            char ch = 'x';

            if (ch == 'A' || ch == 'a')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'E' || ch == 'e')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'I' || ch == 'i')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'O' || ch == 'o')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'U' || ch == 'u')
            {
                WriteLine("Vowel");
            }
            else
            {
                WriteLine("Consonant");
            }



            int option, a, b, total;

            WriteLine("please enter your first number");
            a = Convert.ToInt32(ReadLine());

            WriteLine("please enter your second number");
            b = Convert.ToInt32(ReadLine());


            WriteLine("1 - add number, 2 - subtraction, 3 - multiply, 4 - divide");
            option = Convert.ToInt32(ReadLine());

            switch(option)
            {
                case 1:
                    total = (a + b);
                    WriteLine("your tatal is {0}", total);
                    break;
                case 2:
                    total = (a - b);
                    WriteLine("your tatal is {0}", total);
                    break;
                case 3:
                    total = (a * b);
                    WriteLine("your tatal is {0}", total);
                    break;
                case 4:
                    total = (a / b);
                    WriteLine("your tatal is {0}", total);
                    break;
                default:
                    WriteLine("YOU DIDN'T SELECT 1-4");
                    break;
            }

            ReadKey();

        }
    }
}
