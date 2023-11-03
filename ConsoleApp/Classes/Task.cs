using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Cost? Cost { get; set; }
        public int Priority { get; set; }
        public DateTime LastCompletedDate { get; set; }
        public int Tolerance { get; set; }
        public List<Step> Steps { get; set; } = new List<Step>();
        public TimeOnly TimeOfDay { get; set; }


    }
}
