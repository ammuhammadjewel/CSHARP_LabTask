using System;
namespace Final_LabTask
{
    public abstract class Faculty : Person
    {
        private string facultyId;
        private string joiningDate;
        private int salary;

        public abstract void FacultySatus();

        
        public string FacultyId
        {
            get { return this.facultyId; }
            set { this.facultyId = value; }
        }
        public string JoiningDate
        {
            get { return this.joiningDate; }
            set { this.joiningDate = value; }
        }
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        /*public Faculty()
        {
            base.Name = "";
            base.Age = 0;
            base.Address = "";
            this.facultyId = "";
            this.joiningDate = "";
            this.salary = 0;
            Console.WriteLine("Faculty emty cons called!");
        }*/

        public Faculty(string name, int age, string address, string facultyId, string joiningDate, int salary) : base(name, age, address)
        {
            base.Name = name;
            base.Age = age;
            base.Address = address;
            this.facultyId = facultyId;
            this.joiningDate = joiningDate;
            this.salary = salary;

            Console.WriteLine("Faculty para cons called!");
        }

        public override void PerosnSatus()
        {
            Console.WriteLine("Faculty status");
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Faculty Name: " + Name);
            Console.WriteLine("Faculty Age: " + Age);
            Console.WriteLine("Faculty address: " + Address);
            Console.WriteLine("Faculty Id: " + FacultyId);
            Console.WriteLine("Faculty Joining Date: " + joiningDate);
            Console.WriteLine("Faculty Salary: " + Salary);
        }
    }
}