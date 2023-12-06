using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Project_3
{
    public class TaskTrackerApp
    {
        public static void Run()
        {
            List<Task> tasks = new List<Task>();

            string userChoice;
            do
            {
                WriteLine("1. Add Task");
                WriteLine("2. View Tasks");
                WriteLine("3. Mark Task as Complete");
                WriteLine("4. Exit");

                Write("Enter your choice: ");
                userChoice = ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddTask(tasks);
                        break;
                    case "2":
                        ViewTasks(tasks);
                        break;
                    case "3":
                        MarkTaskComplete(tasks);
                        break;
                    case "4":
                        WriteLine("Exiting Task Tracker. Goodbye!");
                        break;
                    default:
                        WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (userChoice != "4");
        }

        private static void AddTask(List<Task> tasks)
        {
            Write("Enter task description: ");
            string description = ReadLine();

            Task task = new Task(description);
            tasks.Add(task);

            WriteLine("Task added successfully!");
        }

        private static void ViewTasks(List<Task> tasks)
        {
            WriteLine("Tasks:");

            foreach (var task in tasks)
            {
                WriteLine($"- {task.Description} (Complete: {task.IsComplete})");
            }
        }

        private static void MarkTaskComplete(List<Task> tasks)
        {
            ViewTasks(tasks);

            Write("Enter the index of the task to mark as complete: ");
            if (int.TryParse(ReadLine(), out int index) && index >= 0 && index < tasks.Count)
            {
                tasks[index].MarkComplete();
                WriteLine("Task marked as complete!");
            }
            else
            {
                WriteLine("Invalid index. Please try again.");
            }
        }
    }
}
