using System;
using System.Runtime.CompilerServices;
//using System.Security.AccessControl;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Console.Write("Write your name: "); 
             //string name = Console.ReadLine();

             int myNum = 15;
             myNum = 20;
             Console.WriteLine("The number 15 is replaced with 20: " +myNum);


             const int myNum2 = 15;
             //myNum2 = 20; //it will be show error for hole code 

             Console.Write("Enter your firstName: ");
             string firstName = Console.ReadLine() ;
             Console.Write("Enter your last Name: ");
             string lastName = Console.ReadLine();
             string fullName = firstName + lastName;
             Console.WriteLine("Enter your first and lasName in the fullName section: " +fullName);



             //Console.WriteLine("Hi!: " +name);   //This is comment
             Console.WriteLine("I am Learning c#"); /* This is multiline commments
             Console.WriteLine("It is awesome!");
             Console.WriteLine(3 + 3);



             int x = 5, y = 6, z = 50; //to declare more than one variable of the same type, use comma-separated list
             Console.WriteLine(x + y + z);

            int x, y, z; //same value to multiple varirables in one line
            x = y = z = 50;
            Console.WriteLine(x+y+z);


            // Scientific Numbers
            float f1 = 35e3F;   // e or E indicate the power of 10
            double d1 = 12E4D;

            Console.WriteLine("This is f1 value: " +f1);
            Console.WriteLine("This is d1 value: " +d1);


            // Boolean true or false

            bool isCSharpFun = true;
            bool isFishTasty = false;

            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);*/

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));


        }
    }
}