using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interitance_Task
{
    internal class Car : Vehicle
    {
        public override void status()
        {
            Console.WriteLine("Status: Car Is Working");
        }
    }
}
