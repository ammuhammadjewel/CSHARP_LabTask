using System;
namespace Shape
{
    class Shape //base class
    {
        private double variable1;
        private double variable2;

        public double Variable1
        {
            get { return variable1; }
            set { variable1 = value; }
        }
        public double Variable2
        {
            get { return variable2; }
            set { variable2 = value; }
        }

        public Shape()
        {
            this.variable1 = 0;
            this.variable2 = 0;
            Console.WriteLine("cons called Shape!");
        }
        public Shape(double Variable1, double variable2)
        {
            variable1 = Variable1;
            variable2 = Variable2;
            Console.WriteLine("parameterized cons called Shape");
        }
        public virtual void Show()
        {
            Console.WriteLine("Shape Variable 1: " +this.Variable1);
            Console.WriteLine("Shape Variable 2: " + this.Variable2);
        }
    }
    class Circlee: Shape
    {
        public Circlee()
        {
            Console.WriteLine("Ciclee cons called!");

            //public void Show
        }
    }

}