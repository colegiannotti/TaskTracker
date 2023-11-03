using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class PeriodicTask : Task
    {
        public int Period { get; set; }
        public PeriodUnit Unit { get; set; }
    }
}
