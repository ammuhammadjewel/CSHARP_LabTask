using System;
namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape();
            Shape shape = new Shape();
            //Shape.this.Variable1();
            shape.Show();
            Console.WriteLine();

            Circlee circlee = new Circlee();
            

            Circle circle = new Circle();
            circle.Show();
            circle.AreaCalculate(12);
            Console.WriteLine();

            Rectangle rectangle = new Rectangle();
            rectangle.Show();
            rectangle.AreaCalculate(12,15);
            Console.WriteLine();

            Triangle triangle = new Triangle();
            triangle.Show();
            triangle.AreaCalculate(12,14);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}