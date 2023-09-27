using System;
using System.Security.Cryptography.X509Certificates;

namespace Shape
{
    class Circle: Shape // derived class (child)
    {
        const double Pi = 1.5;

        public Circle()
        {
            Console.WriteLine("Circle emty cons called !");
        }
        
        public Circle(int c1)
        {
            Console.WriteLine("Circle cons called c1!" +c1);
        }

        public override void Show()
        {
            Console.WriteLine("Field variable_1 from Circle: " +this.Variable1);
            Console.WriteLine("Field variable_2 form Circle: " +this.Variable2);
            Console.WriteLine("Cicle value of Pi " +Pi);
            Console.WriteLine();
        }
        public void AreaCalculate(double radious)
        {
            //Console.Write("Enter Radius: ");
            //double radious = Convert.ToDouble(Console.ReadLine());
            //double radi
            
            double area = 3.1416 * radious * radious;
            Console.WriteLine("Area of circle is: " + area);
        }
    }
}