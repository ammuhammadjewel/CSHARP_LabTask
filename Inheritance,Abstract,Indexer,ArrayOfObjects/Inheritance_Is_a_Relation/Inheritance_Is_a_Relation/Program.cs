using System;
namespace Inheritance_Is_a_Relation
{
    class A
    {
        private int num1; //private member
        public A() //default cons
        {
            this.num1 = 0;
            Console.WriteLine("A");
        }
        public int Num1 //properties
        {
            set { this.num1 = value; }
            get { return this.num1; }
        }
        virtual public void Method() 
        {
            Console.WriteLine("A method called!");
        }
    }
    class B:A
    {
        private int num2;
        public B()
        {
            this.num2 = 0;
           Console.WriteLine("B");
        }
        override public void Method()
        {
            Console.WriteLine("B method called!");
        }
        public B(int x, int y)
        {
            base.Num1 = x;
            this.num2 = y;
            Console.WriteLine("Para B");
        }
        public int Num2
        {
            set { this.num2 = value; }
            get { return this.num2; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj1 = new B();
            obj1.Num1 = 1;
            obj1.Num2 = 2;
            Console.WriteLine(obj1.Num1 + " " + obj1.Num2);
            Console.WriteLine();

            B obj2 = new B(3, 4);
            Console.WriteLine();

            A obj3 = new B();
            obj3.Num1 = 3;
            ((B)obj3).Num2 = 4;
            obj3.Method();

            Console.ReadKey();

        }
    }
}