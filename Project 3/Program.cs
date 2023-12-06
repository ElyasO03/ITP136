using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // TaskTracker - A console-based task tracking application.
            // This program allows users to add tasks, view their tasks, and mark tasks as complete.

            TaskTrackerApp.Run();

            ReadKey();
        }
    }
}
