using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAPI.Models
{
    public class TaskDetails
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Progress { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
