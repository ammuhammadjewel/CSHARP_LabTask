using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interitance_Task
{
    internal class Vehicle
    {
        private string vehicleName;
        private string vehicleId;
        public static int vehicleCount = 0;

        public string VehicleName
        {
            set
            {
                this.vehicleName = value;
            }
            get
            {
                return this.vehicleName;
            }
        }
        public string VehicleId
        {
            set
            {
                this.vehicleId = value;
            }
            get
            {
                return this.vehicleId;
            }
        }

        public Vehicle()
        {
            this.vehicleName = "";
            this.vehicleId = "";
            vehicleCount++;
        }
        public virtual void status()
        {
            Console.WriteLine("Status: Vehicle Is Working");
        }

        public void showInfo()
        {
            Console.WriteLine("Showing Info:");
            Console.WriteLine("Vehicle Name: {0}", this.vehicleName);
            Console.WriteLine("Vehicle ID: {0}", this.vehicleId);
        }

        
    }
}
