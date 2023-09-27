using Car;
using System;
namespace Car
{
    class Vehicle
    {
        private string vehicleName = " ";
        private string vehicleId = "";
        public int vehicleCount;

        public Vehicle() { }

        public Vehicle(string VehicleName, string VehicleId)
        {
            this.vehicleName = VehicleName;
            this.vehicleId = VehicleId;
            vehicleCount++;
            Console.WriteLine("Vehicle cons called!");
        }
        public String VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }
        public string VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public virtual void status()
        {
            Console.WriteLine("Working");
        }

        public virtual void showInfo()
        {
            Console.WriteLine("Vehicle Name: " + this.VehicleName);
            Console.WriteLine("Vehicle Id: " + this.VehicleId);
        }
    }
    
    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            Console.WriteLine("Motorbike cons called!");
            
        }
        public override void showInfo()
        {
            Console.WriteLine("Motobike Name: " + this.VehicleName);
            Console.WriteLine("Motorbike ID: " + this.VehicleId);
            
        }
        public override void status()
        {
            base.status();
            
        }
    }
    class Truck : Vehicle
    {
        public Truck() { Console.WriteLine("Truck cons called!"); }

        public override void status()
        {
            Console.WriteLine("Truck working");
        }
        public override void showInfo()
        {
            Console.WriteLine("Truck Name:" + this.VehicleName);
            Console.WriteLine("Truck Id: " + this.VehicleId);
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car cons called!");
        }

        public override void status()
        {
            
            base.status();
        }
        public override void showInfo()
        {
            Console.WriteLine("Car Name: " + this.VehicleName);
            Console.WriteLine("Car Id: " + this.VehicleId);
        }
    }
    class Saloon : Car
    {
        public Saloon() { }


        public override void status()
        {
            base.status();
            
        }

        public override void showInfo()
        {
            Console.WriteLine("Saloon Name" + this.VehicleName);
            Console.WriteLine("Saloon Id: " + this.VehicleId);
        }
    }

    class MPV : Car
    {
        public MPV()
        {
            Console.WriteLine("MPV cons called");
        }

        public override void status()
        {
            base.status();
        }
        public override void showInfo()
        {
            Console.WriteLine("MPV Name: " + this.VehicleName);
            Console.WriteLine("MPV Id: " + this.VehicleId);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("aaa", "a12");
            Console.WriteLine("Vehicle Count: " + vehicle.vehicleCount);
            Console.WriteLine();


            Vehicle obj1 = new Motorbike();
            obj1.status();
            obj1.showInfo();
            Console.WriteLine("Motor Bike Cout: " + vehicle.vehicleCount);
            Console.WriteLine();
            

            Vehicle obj2 = new Truck();
            obj1.VehicleName = "Truck";
            obj2.VehicleId = "a13";
            obj2.status();
            obj2.showInfo();
            Console.WriteLine("Truck Count: " + vehicle.vehicleCount);
            Console.WriteLine();

            Vehicle obj3 = new Car();
            obj3.VehicleName = "Car";
            obj3.VehicleId = "a14";
            obj3.status();
            obj3.showInfo();
            Console.WriteLine("Car Count: " + vehicle.vehicleCount);
            Console.WriteLine();

            Vehicle obj4 = new Saloon();
            obj2.VehicleName = "Saloon";
            obj2.VehicleId = "s15";
            obj4.status();
            obj4.showInfo();
            Console.WriteLine("Saloon Count: " + vehicle.vehicleCount);
            Console.WriteLine();

            Vehicle obj5 = new MPV();
            obj5.VehicleName = "MPV";
            obj5.VehicleId = "a16";
            obj5.status();
            obj5.showInfo();
            Console.WriteLine("MPV Count: " + vehicle.vehicleCount);

            Console.ReadLine();
        }
    }
}