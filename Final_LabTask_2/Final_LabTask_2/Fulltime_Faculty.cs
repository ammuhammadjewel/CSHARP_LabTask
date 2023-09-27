using System;
namespace Final_LabTask
{
    public partial class FulltimeFaculty : Faculty
    {
        private string nextIncrementDate;

        /*public FulltimeFaculty() 
        {
            base.FacultyId = "";
            base.Age = 0;
            base.Address = "";
            this.NextIncreamentDate = "";
            Console.WriteLine("FulltimeFacultu Empty cons called"); 
        }*/

        public FulltimeFaculty(string name, int age, string address, string facultyId, string joiningDate, int salary, string NextIncreamentDate) : base (name, age, address, facultyId, joiningDate, salary)
        {
            base.Name = name;
            base.Age = age;
            base.Address = address;
            base.FacultyId = facultyId;
            base.JoiningDate = joiningDate;
            base.Salary = salary;
            this.nextIncrementDate = NextIncreamentDate;
            Console.WriteLine("FullTimeFacultu cons called!");
        }
        public string NextIncreamentDate
        {
            get { return this.nextIncrementDate; }
            set { this.nextIncrementDate = value; }
        }
        public override void FacultySatus()
        {
            Console.WriteLine("Full time Faculty on the Duty");
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Next Increament Date: " +this.NextIncreamentDate);
        }
    }
}