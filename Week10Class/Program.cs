using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Week10Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1313, "David Stephens");

            WriteLine(emp1.EmployeeNum + " " + emp1.FulName);

            ReadKey();

            List<Salary> salList = new List<Salary>();

            WriteLine("How many employees do you want to add? ");
            int inputAnswer = Convert.ToInt32(ReadLine());

            for (int x = 0; x < inputAnswer; x++)
            {
                WriteLine("Enter the employee number");
                int empNum = Convert.ToInt32(ReadLine());

                WriteLine("Enter the employee full name");
                string fn = ReadLine();

                WriteLine("Enter the employee salary");
                double sa = Convert.ToDouble(ReadLine());

                salList.Add(new Salary(empNum, fn, sa));
            }

            List<Commission> comList = new List<Commission>();

            comList.Add(new Commission(8947, "Bill Gates", 500));
            comList.Add(new Commission(5468, "Elon Musk", 200));

            foreach (Salary sa in salList)
            {
                WriteLine(sa.EmployeeNum + " " + sa.FulName + " " + sa.SalaryAmount);
            }

            foreach (Commission co in comList)
            {
                WriteLine(co.EmployeeNum + " " + co.FulName + " " + co.Sales);
            }

            ReadKey();
        }
    }
}
