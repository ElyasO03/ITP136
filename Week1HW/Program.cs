using System;

namespace HelloWorld
{
    using static System.Console;
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string patientName = Console.ReadLine();

            Console.WriteLine("Your name is " + patientName);
            Console.ReadKey();
        }
    }
}