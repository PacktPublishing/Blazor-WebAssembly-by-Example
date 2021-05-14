using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Shared
{
    public class TaskItem
    {
        public int TaskItemId { get; set; }
        public string TaskName { get; set; }
        public bool IsComplete { get; set; }
    }
}
