﻿

//		********* Task - 1 ********
using System;
namespace labTask
{

    class Programe
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Student Information");

            string firstName = "asif";
            string lastName = "ali";
            string birthdate = "12/12/2000";
            string addressLine1 = "kuril";
            string addressLine2 = "kuril";
            string city = "dhaka";
            string state = "dhaka";
            int zip = 1200;
            string country = "Bangladesh";

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("birthdate: " + birthdate);
            Console.WriteLine("address Line 1: " + addressLine1);
            Console.WriteLine("address Line 2: " + addressLine2);
            Console.WriteLine("city name: " + city);
            Console.WriteLine("state name: " + state);
            Console.WriteLine("zip code: " + zip);
            Console.WriteLine("country name: " + country);

        }
    }
}



//*********** Task 2 * **********

/*

namespace labTask
{

    class Programe
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Student Information");

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter birtDate: ");
            string birthdate = Console.ReadLine();
            Console.Write("Enter address Line 1: ");
            string addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter address Line 2: ");
            string addressLine2 = Console.ReadLine();
            Console.Write("Enter city name: ");
            string city = Console.ReadLine();
            Console.Write("Enter state name: ");
            string state = Console.ReadLine();
            Console.Write("Enter zip code: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter country name: ");
            string country = Console.ReadLine();

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("birthdate: " + birthdate);
            Console.WriteLine("address Line 1: " + addressLine1);
            Console.WriteLine("address Line 2: " + addressLine2);
            Console.WriteLine("city name: " + city);
            Console.WriteLine("state name: " + state);
            Console.WriteLine("zip code: " + zip);
            Console.WriteLine("country name: " + country);

        }
    }
}



//**********Task 3 * ********

namespace labtask
{

    struct studentInfo
    {
        public string firstName;
        public string lastName;
        public string birthDate;
        public string addressLine_1;
        public string addressLine_2;
        public string cityName;
        public string stateName;
        public int zip;
        public string countryName;

    }
    class Program
    {
        static void Main(string[] args)
        {
            studentInfo details = new studentInfo();

            Console.Write("Enter First name: ");
            details.firstName = Console.ReadLine();
            Console.Write("Enter Last name: ");
            details.lastName = Console.ReadLine();
            Console.Write("Enter bithdate: ");
            details.birthDate = Console.ReadLine();
            Console.Write("Enter addressline 1: ");
            details.addressLine_1 = Console.ReadLine();
            Console.Write("Enter addressline 2: ");
            details.addressLine_2 = Console.ReadLine();
            Console.Write("Enter city name: ");
            details.cityName = Console.ReadLine();
            Console.Write("Enter state name: ");
            details.stateName = Console.ReadLine();
            Console.Write("Enter zip code: ");
            details.zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter country name: ");
            details.countryName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(" First Name is: " + details.firstName);
            Console.WriteLine(" Last Name is: " + details.lastName);
            Console.WriteLine(" Birthdate: " + details.birthDate);
            Console.WriteLine(" addressline 1: " + details.addressLine_1);
            Console.WriteLine(" addressline 2: " + details.addressLine_2);
            Console.WriteLine(" city Name: " + details.cityName);
            Console.WriteLine(" state Name: " + details.stateName);
            Console.WriteLine("zip code: " + details.zip);
            Console.WriteLine("contry name: " + details.countryName);


        }
    }
}



//********Task 4 * *****




namespace Calcutation
{
    class Area
    {
        public float length, breadth, radius, side, hieght;
        static void Main(string[] args)
        {
            Area a = new Area();
            a.circle();
            a.rectangle();
            a.triangle();
            Console.ReadKey();

        }
        public void circle()
        {
            Console.Write("Enter the Radius of the circle: ");
            radius = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("Area of circle is:{0}", 3.1416 * radius * radius);

        }
        public void rectangle()
        {
            Console.Write("Eter the Length for rectangle: ");
            length = float.Parse(Console.ReadLine());
            Console.Write("Enter the breadth for rectangle: ");
            breadth = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("Area of rectangle is :{0}", length * breadth);
        }
        public void triangle()
        {
            Console.Write("Enter the breadth for triangle: ");
            breadth = float.Parse(Console.ReadLine());
            Console.Write("Enter the hieght for traingle: ");
            hieght = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("Area of traingle is: {0}", (breadth * hieght) / 2);
        }
    }
}

*/




//********** Task 5 ********










// Area of Rectangle, Square, Triangle, Circle
/*



using System;
namespace ConsoleApplication1
{
    class CalcAvgPerc //Calculate the Average marks and percentage for students  
    {
        public float length, breadth, radius, side, hieght, breadthfortriangle;
        static void Main(string[] args)
        {
            CalcAvgPerc a = new CalcAvgPerc();
            a.Rectangle();
            a.Circle();
            a.Square();
            a.Triangle();
            Console.ReadKey();
        }
        public void Rectangle()
        {
            Console.WriteLine("Enter the Length for Rectangle");
            length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth for Rectangle");
            breadth = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Area of rectangle is :{0}", length * breadth);
        }
        public void Circle()
        {
            Console.WriteLine("Enter the Radius of the Circle");
            radius = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Area of Circle is:{0}", 3.14 * radius * radius);
        }
        public void Square()
        {
            Console.WriteLine("Enter the side of a square");
            side = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Area of Square is:{0}", side * side);
        }
        public void Triangle()
        {
            Console.WriteLine("Enter the Breadth for Triangle ");
            breadthfortriangle = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hieght for Triangle ");
            hieght = float.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Area of Triangle is:{0}", (breadthfortriangle * hieght) / 2);
        }
    }
}*/