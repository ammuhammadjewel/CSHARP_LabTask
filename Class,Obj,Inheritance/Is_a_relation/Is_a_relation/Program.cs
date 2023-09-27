using System;
namespace Is_a_relation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human obj1 = new Human();
            Console.WriteLine(obj1.name1);
            obj1.Method();
            Console.WriteLine();

            Student obj2 = new Student();
            Console.WriteLine(obj2.name2);
            obj2.Method();
            //After inheritance
            Console.WriteLine(obj2.name1);
            obj2.Method();
            obj2.CallHuman();
            Console.WriteLine();

            Human obj3 = new Student(); //upcasting
            Console.WriteLine(obj3.name1);
            obj3.Method(); //overriding 
            ((Student)obj3).CallHuman(); //without overiding
            Console.WriteLine();

            Human obj4 = new CSE(); //upcasting
            Console.WriteLine(obj4.name1);
            obj4.Method(); //overriding
            ((Student)obj4).CallHuman(); //without overiding
            Console.WriteLine();

            Student obj5 = new CSE();
            Console.WriteLine(obj5.name1);
            Console.WriteLine(obj5.name2);
            obj5.Method(); //overriding
            obj5.CallHuman();
            obj5.AnotherMethod();

            Console.ReadKey();
        }
    }
}