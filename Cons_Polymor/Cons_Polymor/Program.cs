using System;
namespace Cons_Polymor
{
    class Vehicle
    {
        public string vehicleName;
        private string vehicleId;
        public static int vehicleCount;


        public Vehicle()
        {
            this.vehicleId = " ";
            Console.WriteLine("Default Cons called!.");
        }
        public string VehicleId
        {
            set { vehicleId = value;  }
            get { return vehicleId;  }
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }