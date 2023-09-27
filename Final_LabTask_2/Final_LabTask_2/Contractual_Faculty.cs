using System;
namespace Final_LabTask
{
    public partial class ContractulaFaculty : Faculty
    {
        private string duration;

        /*public ContractulaFaculty()
        {
            this.duration = "";
            Console.WriteLine("Constractula Faculty emty cons called");
        }*/
        public ContractulaFaculty(string name, int age, string address, string facultyId, string joiningDate, int salary, string duration) : base (name, age, address, facultyId, joiningDate, salary)
        {
            base.Name = name;
            base.Age = age;
            base.Address = address;
            base.FacultyId = facultyId;
            base.JoiningDate = joiningDate;
            base.Salary = salary;
            this.duration = Duration;
            Console.WriteLine("Constratual Faculty para cons called");
        }
        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override void FacultySatus()
        {
            Console.WriteLine("Constratula Faculty on the duty");
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Next Duration: " +this.Duration);
        }
    }
}