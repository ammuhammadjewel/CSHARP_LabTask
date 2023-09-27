using System;
namespace Shape
{
    class Rectangle: Shape // derived class (child)
    {
        public Rectangle() //cons 2
        {
            Console.WriteLine("Rectangle cons called 1!");
        }
        public Rectangle(int r) //cons 2
        {
            Console.WriteLine("Rectangle cons called 2!" +r);
        }

        public override void Show()
        {
            Console.WriteLine("Field variable_1 from Rectangle: " +this.Variable1);
            Console.WriteLine("Field variable_2 from Ractangle: " +this.Variable2);
        }
        public void AreaCalculate(float width, float height)
        {
            float area = width * height;
            Console.WriteLine("Rectangle Area: " +area);
        }

    }

}