using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_3
{
    public class PriorityTask : Task
    {
        public int PriorityLevel { get; set; }

        public PriorityTask(string description, int priorityLevel) : base(description)
        {
            PriorityLevel = priorityLevel;
        }
    }
}