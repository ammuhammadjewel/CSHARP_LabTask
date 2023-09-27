namespace Interface
{
    interface ISleepable
    {
        void Sleep();
        void Work();
    }
    interface IRunnable
    {
        void Run();
        void Work();
    }
    class Animal
    {
        public void Status()
        {
            Console.WriteLine("It is a animal");
        }
        public virtual void Eat() 
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog: Animal, ISleepable, IRunnable
    {
        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
        public void Run()
        {
            Console.WriteLine("Dog is running");
        }
        void ISleepable.Work()
        {
            Console.WriteLine("Dog is working => ISleepable");
        }
        void IRunnable.Work()
        {
            Console.WriteLine("Dog is working => IRunnable");
        }
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ISleepable obj1 = new Dog();
            obj1.Sleep();
            obj1.Work();
            ((Dog)obj1).Eat(); //class casting
            Console.WriteLine();

            IRunnable obj2 = new Dog();
            obj2.Run();
            obj2.Work();
            ((Dog)obj2).Eat(); //class casting
            Console.WriteLine();

            ((Animal)obj2).Status();
            ((ISleepable)obj2).Work(); //interface casting
            ((IRunnable)obj1).Work(); //interface casting

            Console.ReadLine();
        }
    }
}