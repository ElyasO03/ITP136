using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Week8Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1313, 1200.00, "Stephens", "Dave", "Proffesor");

            WriteLine(emp1.EmployeeNumber + " " + emp1.Salary + " " + emp1.LastName + " " + emp1.FirstName + " " + emp1.Position);

            int numEmp;


            WriteLine("How many employees do you want to enter?");

            numEmp = Convert.ToInt32(ReadLine());

            Employee[] empArray = new Employee[numEmp];

            for (int x = 0; x < empArray.Length; x++)
            {
                populateEmployee(ref empArray[x]);
            }

            for (int y = 0; y < empArray.Length; y++)
            {
                WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}", empArray[y].EmployeeNumber, empArray[y].Salary, empArray[y].LastName, empArray[y].FirstName, empArray[y].Position);
            }

            WriteLine("Which employee do you want to modify?");

            for (int z = 0; z < empArray.Length; z++)
            {
                WriteLine("{0,20}{1,20}{2,20}{3,20} ", z + 1, empArray[z].EmployeeNumber, empArray[z].Salary, empArray[z].LastName, empArray[z].FirstName, empArray[z].Position);
            }

            int selectedEmployee = Convert.ToInt32(ReadLine());

            modifyEmployee(ref empArray[selectedEmployee - 1]);

            WriteLine("{0,20}{1,20}{2,20}{3,20}", "Employee Number", "Last Name", "Positin", "Salary");

        }

        static void populateEmployee(ref Employee e)
        {
            WriteLine("Please enter Employee number");
            int empNum = Convert.ToInt32(ReadLine());

            WriteLine("Please enter employee salary");
            double a = Convert.ToDouble(ReadLine());

            WriteLine("Please enter a last name");
            string lastname = ReadLine();

            WriteLine("Please enter a first name");
            string firstname = ReadLine();

            WriteLine("Please enter a position");
            string position = ReadLine();

            e = new Employee(empNum, a, lastname, firstname, position);

            ReadKey();

        }

        static void modifyEmployee(ref Employee e)
        {
            WriteLine("would you like to update \n 1. Employee number \n 2. Last Name \n 3. First Name \n 4. Position \n 5. Salary");

            int userInput = Convert.ToInt32(ReadLine());

            if (userInput == 1)
            {
                WriteLine("Please update employee number");
                int newNum = Convert.ToInt32(ReadLine());

                e.EmployeeNumber = newNum;
            }
            else if (userInput == 2)
            {
                WriteLine("Please update employee last name");
                string lname = ReadLine();

                e.LastName = lname;
            }
            else if (userInput == 3)
            {
                WriteLine("Please update employee first name");
                string fname = ReadLine();

                e.FirstName = fname;
            }
            else if (userInput == 4)
            {
                WriteLine("Please update employee position");
                string position = ReadLine();

                e.LastName = position;
            }
            else if (userInput == 5)
            {
                WriteLine("Please update salary");
                double salary = Convert.ToDouble(ReadLine());

                e.Salary = salary;
            }
            else
            {
                WriteLine("Please enter a valid number");
            }
            ReadKey();

        }
    }
   
}

