using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public bool Done { get; set; }
    }
}
