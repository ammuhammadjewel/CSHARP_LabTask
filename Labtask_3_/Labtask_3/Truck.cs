using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interitance_Task
{
    internal class Truck : Vehicle
    {
        public override void status()
        {
            Console.WriteLine("Status: Truck Is Working");
        }
    }
}
