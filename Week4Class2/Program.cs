using System;
using static System.Console;

namespace Week4Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = 0;
            b = 5;

            while(a < b)
            {
                WriteLine(a);

                a++;
            }
            WriteLine(a);
            ReadKey();
        }
    }
}
