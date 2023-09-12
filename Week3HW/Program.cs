using System;
using static System.Console;

namespace Week3HW
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("a. Doctor – Sick Appointment");
                Console.WriteLine("b. Doctor – Check-up");
                Console.WriteLine("c. Exit");
                Console.Write("Enter your choice (a/b/c): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        Console.Write("Is the patient a child or an adult (child/adult): ");
                        string patientType = Console.ReadLine();
                        decimal baseCharge = 0;

                        if (patientType == "child")
                        {
                            baseCharge = 50;
                        }
                        else if (patientType == "adult")
                        {
                            baseCharge = 75;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter 'child' or 'adult'.");
                            continue;
                        }

                        Console.Write("Did the user have labs done (yes/no): ");
                        string labsDone = Console.ReadLine();

                        if (labsDone == "yes")
                        {
                            baseCharge += 25;
                        }

                        Console.WriteLine($"Total charge for the appointment: {baseCharge:C}");
                        break;

                    case "b":
                        Console.Write("Is the patient a child or an adult (child/adult): ");
                        string patientTypeCheckup = Console.ReadLine();
                        decimal checkupCharge = 0;

                        if (patientTypeCheckup == "child")
                        {
                            checkupCharge = 75;
                        }
                        else if (patientTypeCheckup == "adult")
                        {
                            checkupCharge = 100;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter 'child' or 'adult'.");
                            continue;
                        }

                        Console.WriteLine($"Total charge for the check-up: {checkupCharge:C}");
                        break;

                    case "c":
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select 'a', 'b', or 'c'.");
                        break;
                }
                ReadKey();
            }
        }
    }
}
