using System;
using static System.Console;

namespace Week4Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.EmployeeId = 1234;
            emp1.FirstName = "John";
            emp1.LastName = "Smith";

            emp2.EmployeeId = 4567;
            emp2.FirstName = "Bill";
            emp2.LastName = "Jones";

            WriteLine("{0,10} {1,10} {2,10}", "employeeId", "FirstName", "LastName");

            WriteLine("{0,10} {1,10} {2,10}", emp1.EmployeeId, emp1.FirstName, emp1.LastName);

            WriteLine("{0,10} {1,10} {2,10}", emp2.EmployeeId, emp2.FirstName, emp2.LastName);


            WriteLine("Enter Employee Id");

            emp2.EmployeeId = Convert.ToInt32(ReadLine());

            WriteLine("Enter Employee First name");

            emp2.FirstName = ReadLine();

            WriteLine("Enter Employee Last name");
            emp2.LastName = ReadLine();

            WriteLine("{0,10} {1,10} {2,10}", emp2.EmployeeId, emp2.FirstName, emp2.LastName);

            ReadKey();
        }
    }

}
