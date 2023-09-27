using System;
using System.Security.Cryptography;

namespace Indexer
{
    class OOP2E
    {
        string[] name = new string[5]; //private member by default

        //indexer concept
        public string this[int index] //indexer property
        {
            set { name[index] = value; }
            get { return name[index]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexer
            OOP2E obj1 = new OOP2E();
            obj1[0] = "Abiad";
            obj1[1] = "Sajid";
            obj1[2] = "Tanvir";
            obj1[3] = "Risun";
            obj1[4] = "Zarin";
            Console.WriteLine(obj1[0]);
            Console.WriteLine();
            
            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine(obj1[i]);
            }
            Console.ReadKey();
        }
    }
}