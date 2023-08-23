using System;

namespace Week1HW
{
    using static System.Console;
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who is being seen today?");

            string patientName = Console.ReadLine();

            Console.WriteLine("Welcome " + patientName);
        }
    }
}
