using System;
namespace LabTask_2
{
    class Fulltime_faculty : Faculty
    {
        private string nextIncrementDate;

        public Fulltime_faculty()
        {
            this.nextIncrementDate = "";

            Console.WriteLine("Fulltime Faculty emty constructor called.");

        }
        public Fulltime_faculty(string NextIncrementDate)
        {
            this.nextIncrementDate = NextIncrementDate;

            Console.WriteLine("Fulltime faculty parameterized constructor called");

        }

        public string NextIncrementDate
        {
            get { return this.nextIncrementDate; }
            set { this.nextIncrementDate = value; }
        }

        public void FacultyStatus()
        {
            Console.WriteLine("");
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Full time faculty name: " + this.Name);
            Console.WriteLine("Full time faculty Age: " + this.Age);
            Console.WriteLine("full time faculty address: " +this.Address);
            Console.WriteLine("full time faculty id: " + this.FacultyId);
            Console.WriteLine("Full time faculty joining Date: " + this.JoiningDate);
            Console.WriteLine("Full time faculty salary: " + this.Salary);
            Console.WriteLine("Full time faculty next increment Date: " + this.NextIncrementDate);
        }
    }
}