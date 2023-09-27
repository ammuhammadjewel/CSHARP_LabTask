using System;
namespace Abstraction
{
    abstract class A
    {
        public void NonAbsMethodA()
        {
            Console.WriteLine("Non abs method of A");
        }
        abstract public void AbsMethod();
    }
    class B:A
    {
        public void NonAbsMethodB()
        {
            Console.WriteLine("Non abs method of B");
        }
        override public void AbsMethod()
        {
            Console.WriteLine("Abs method implemented in B");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new B();
            obj1.NonAbsMethodA();
            ((B)obj1).AbsMethod();
            Console.ReadKey();
        }
    }
}