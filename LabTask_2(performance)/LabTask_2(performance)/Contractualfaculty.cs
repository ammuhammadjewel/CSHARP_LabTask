using System;

namespace LabTask_2
{
    class Contratual_faculty : Faculty
    {
        private string duration;

        public Contratual_faculty()
        {
            this.duration = "";

            Console.WriteLine("contractual emty cons called.");
        }
        public Contratual_faculty(string Duration)
        {
            this.duration = Duration;

            Console.WriteLine("contractula parameterized constructor called.");
        }

        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public void facultyStatus()
        {
            Console.WriteLine("");
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Faculty Name: " + this.Name);
            Console.WriteLine("Faculty Age: " + this.Age);
            Console.WriteLine("Faculty Address: " + this.Address);
            Console.WriteLine("Faculty faculty id: " + this.FacultyId);
            Console.WriteLine("Faculty Joining Date: " + this.JoiningDate);
            Console.WriteLine("Faculty Name: " + this.Salary);
            Console.WriteLine("Constractual faculty Duration" + this.Duration);

        }
    }
}