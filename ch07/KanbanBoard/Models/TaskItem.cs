using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanBoard.Models
{
    public class TaskItem
    {
        public string TaskName { get; set; }
        public TaskPriority Priority { get; set; }
    }
}
