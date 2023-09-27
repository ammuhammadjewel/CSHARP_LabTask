using System;
namespace Class_Obje
{
    internal class Object
    {
        public int num1, num2; //public member
        private int num3, num4; //private member
        public static int count = 0; //static member
        public Object() //default cons
        {
            this.num1 = 0;
            this.num2 = 0;
            Console.WriteLine("Default cons called!");
            count++;
        }
        public Object(int x, int y) //para cons
        {
            this.num3 = x;
            this.num4 = y;
            Console.WriteLine("Para cons called!");
            count++;
        }
        static Object() //static cons
        {
            Console.WriteLine("Stat cons called!");
        }
        static public void Display()
        {
            Console.WriteLine("Static method called!");
        }
        public int Num3 //properties
        {
            set
            {
                this.num3 = value;
            }
            get
            {
                return this.num3;
            }
        }
        public int Num4 //properties
        {
            set
            {
                this.num4 = value;
            }
            get
            {
                return this.num4;
            }
        }
        public void Show()
        {
            Console.WriteLine(this.num1);
            Console.WriteLine(this.num2);
            Console.WriteLine(this.num3);
            Console.WriteLine(this.num4);
        }
    }
}