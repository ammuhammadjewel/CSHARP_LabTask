using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Interitance_Task
{
    internal class MPV : Car
    {
        public override void status()
        {
            Console.WriteLine("Status: MPV Is Working");
        }
    }
}
