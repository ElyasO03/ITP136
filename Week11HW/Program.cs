using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Week11HW
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num1, num2, result;

                WriteLine("Please enter the first number");
                num1 = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the second number");
                num2 = Convert.ToDouble(ReadLine());

                WriteLine("Choose a math operation:");
                WriteLine("1 - Addition");
                WriteLine("2 - Multiplication");
                WriteLine("3 - Subtraction");
                WriteLine("4 - Division");

                int operation = Convert.ToInt32(ReadLine());

                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 * num2;
                        break;
                    case 3:
                        result = num1 - num2;
                        break;
                    case 4:
                        try
                        {
                            result = num1 / num2;
                        }
                        catch (DivideByZeroException e)
                        {
                            WriteLine("Error: Division by zero is not allowed");
                            WriteLine("ERROR: " + e);
                            return;
                        }
                        break;
                    default:
                        WriteLine("Invalid operation selected");
                        return;
                }

                WriteLine("Your result is: " + result);
            }
            catch (FormatException e)
            {
                WriteLine("Error: Invalid input. Please enter numeric values.");
                WriteLine("ERROR: " + e);
            }
            catch (Exception e)
            {
                WriteLine("An unexpected error occurred: " + e);
            }

            ReadKey();
        }
    }
}
