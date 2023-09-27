using System;
namespace LabTask_2
{
    class Person //base class
    {
        private string name;
        private int age;
        private string address;


        public Person() //empty constructor
        {
            this.name = "";
            this.age = 0;
            this.address = "";

            Console.WriteLine("Empty constructor called.");
        }
        public Person(string Name, int Age, string Address)
        {
            name = Name;
            age = Age;
            address = Address;

            Console.WriteLine("Parameterized constructor called");
        }
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


        public void PersonStatus()
        {
            Console.WriteLine(" ");
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Person Name: " + this.Name);
            Console.WriteLine("Person age: " + this.Age);
            Console.WriteLine("Person address: " + this.Address);
        }

    }

}