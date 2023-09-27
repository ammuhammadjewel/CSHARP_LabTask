using System;
using System.Security.Cryptography.X509Certificates;

namespace Class_Obje
{
    internal class Program
    {
        public int num1, num2;
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.num1 = 2;
            obj1.num2 = 3;
            Console.WriteLine(obj1.num1+" "+obj1.num2);
            Console.WriteLine();

            Object obj2 = new Object();
            obj2.num1 = 1;
            obj2.num2 = 2;
            obj2.Num3 = 3;
            obj2.Num4 = 4;
            Console.WriteLine(obj2.num1+obj2.num2+obj2.Num3+obj2.Num4);
            Console.WriteLine();

            Object obj3 = new Object(5,6);
            Console.WriteLine(obj3.Num3 + " " + obj3.Num4);
            obj3.Show();
            Console.WriteLine();

            Console.WriteLine(Object.count);
            Object.Display();

            Console.ReadKey();
        }
    }
}