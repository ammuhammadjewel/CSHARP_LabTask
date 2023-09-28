using Interitance_Task;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Vehicle|");

            Vehicle v1 = new Vehicle();
            v1.VehicleName = "Tesla Model X";
            v1.VehicleId = "5DFG8";
            v1.showInfo();
            v1.status();

            Console.WriteLine();

            Console.WriteLine("|Motor Bike|");

            Vehicle v2 = new MotorBike();
            v2.VehicleName = "Yamaha RTX";
            v2.VehicleId = "6PGO8";
            v2.showInfo();
            v2.status();

            Console.WriteLine();

            Console.WriteLine("|Car|");

            Vehicle v3 = new Car();
            v3.VehicleName = "Toyota Corolla";
            v3.VehicleId = "7RTY5";
            v3.showInfo();
            v3.status();

            Console.WriteLine();

            Console.WriteLine("|Saloon|");

            Vehicle v4 = new Saloon();
            v4.VehicleName = "Skoda Superb";
            v4.VehicleId = "8LLY5";
            v4.showInfo();
            v4.status();

            Console.WriteLine();

            Console.WriteLine("|Truck|");

            Vehicle v5 = new Truck();
            v5.VehicleName = "Tesla Cybertruck";
            v5.VehicleId = "5OOY5";
            v5.showInfo();
            v5.status();

            Console.WriteLine();

            Console.WriteLine("|MPV|");

            Vehicle v6 = new MPV();
            v6.VehicleName = "Tesla Cybertruck";
            v6.VehicleId = "5GHY5";
            v6.showInfo();
            v6.status();

            Console.WriteLine();
            Console.WriteLine("Number Of Vehicle Objects Created: {0}", Vehicle.vehicleCount);



            Console.ReadLine();


        }
    }
}