using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }

        [DisplayName("Nazwa")]
        public string TaskName { get; set; }

        [DisplayName("Opis")]
        public string Description { get; set; }
        
        public bool Done { get; set; }
    }
}
