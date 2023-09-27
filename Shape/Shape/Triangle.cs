using System;
namespace Shape
{
    class Triangle: Shape //// derived class (child)
    {
        double x = .5;

        public Triangle() //cons 1
        {
            Console.WriteLine("Triangle Constractor called 1!");
        }
        public Triangle(int t1) //cons 2
        {
            Console.WriteLine("Traingle cons called 2! " +t1);
        }

        public override void Show()
        {
            Console.WriteLine("Trinagle value of x is: " + x);
            Console.WriteLine("Triangle Variable 1: " +this.Variable1);
            Console.WriteLine("Traingle Variable 2: " +this.Variable2);
        }

        public void AreaCalculate(float height, float baseSize)
        {
            float area = (baseSize * height) / 2;
            Console.WriteLine("Triangle Area: " +area);
        }
    }
}
