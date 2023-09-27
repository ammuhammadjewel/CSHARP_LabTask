using System;
namespace Final_LabTask
{
     public abstract class Person
     {
        private string name;
        private int age;
        private string address;

        public abstract void PerosnSatus();

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            Console.WriteLine("Perons cons called!");
        }
     }
}
