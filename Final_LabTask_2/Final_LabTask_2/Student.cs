using System;
namespace Final_LabTask
{
    public abstract class Student : Person
    {
        private string studentId;
        private double cgpa;
        private int creditComplete;

        public abstract void StudentStatus();

        /*public Student()
        {
            this.studentId = "";
            this.cgpa = 0;
            this.creditComplete = 0;

            Console.WriteLine("Student cons called");
        }*/
        public Student(string name, int age, string address, string studentId, double cgpa, int creditComplete) : base (name, age, address)
        {
            base.Name = name;
            base.Age = age;
            base.Address = address;
            this.studentId = studentId;
            this.cgpa = cgpa;
            this.creditComplete = creditComplete;
            Console.WriteLine("Student para cons called");
        }
        public string StudentId
        {
            get { return this.studentId; }
            set { this.studentId = value; }
        }
        public double Cgpa
        {
            get { return this.cgpa; }
            set { this.cgpa = value; }
        }
        public int CreditComplete
        {
            get { return this.creditComplete; }
            set { this.creditComplete = value; }
        }

        public override void PerosnSatus()
        {
            Console.WriteLine("Students on the class room");
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Address: " + this.Address);
            Console.WriteLine("Student Id: " + this.StudentId);
            Console.WriteLine("Student cgpa: " + this.Cgpa);
            Console.WriteLine("Student credit Completed: " + this.CreditComplete);
        }
    }
}