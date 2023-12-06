using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_3
{
    public class Task
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public Task(string description)
        {
            Description = description;
            IsComplete = false;
        }

        public void MarkComplete()
        {
            IsComplete = true;
        }
    }
}
