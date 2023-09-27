using System;
namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            rabbit.Flee();


            Console.ReadKey();
        }





        /*interface IPrey
        {
            void Flee();
        }*/
        interface Ipredator
        {

        }
        class Rabbit
        {
            public void Flee()
            {
                Console.WriteLine("Rabbit interface Flee");
            }
        }

        
    }
}