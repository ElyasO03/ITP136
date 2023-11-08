using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Week10HW
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the program!");

            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();

            WriteLine("How many students do you want to enter?");
            int numStudents = Convert.ToInt32(ReadLine());

            for (int i = 0; i < numStudents; i++)
            {
                WriteLine("Enter student details:");
                WriteLine("ID Number:");
                int studentId = Convert.ToInt32(ReadLine());

                WriteLine("Full Name:");
                string studentName = ReadLine();

                WriteLine("Address:");
                string studentAddress = ReadLine();

                WriteLine("Major:");
                string studentMajor = ReadLine();

                WriteLine("Advisor:");
                string studentAdvisor = ReadLine();

                studentList.Add(new Student(studentId, studentName, studentAddress, studentMajor, studentAdvisor));
            }

            WriteLine("How many teachers do you want to enter?");
            int numTeachers = Convert.ToInt32(ReadLine());

            for (int i = 0; i < numTeachers; i++)
            {
                WriteLine("Enter teacher details:");
                WriteLine("ID Number:");
                int teacherId = Convert.ToInt32(ReadLine());

                WriteLine("Full Name:");
                string teacherName = ReadLine();

                WriteLine("Address:");
                string teacherAddress = ReadLine();

                WriteLine("Salary:");
                double teacherSalary = Convert.ToDouble(ReadLine());

                WriteLine("Years of Service:");
                int yearsOfService = Convert.ToInt32(ReadLine());

                teacherList.Add(new Teacher(teacherId, teacherName, teacherAddress, teacherSalary, yearsOfService));
            }

            WriteLine("\nStudents:");
            WriteLine("ID\tFullName\tAddress\tMajor\tAdvisor");
            foreach (var student in studentList)
            {
                WriteLine($"{student.IdNum}\t{student.FullName}\t{student.Address}\t{student.Major}\t{student.Advisor}");
            }

            WriteLine("\nTeachers:");
            WriteLine("ID\tFullName\tAddress\tSalary\tYearsOfService");
            foreach (var teacher in teacherList)
            {
                WriteLine($"{teacher.IdNum}\t{teacher.FullName}\t{teacher.Address}\t{teacher.Salary}\t{teacher.YearsOfService}");
            }

            ReadKey();
        }
    }
}
