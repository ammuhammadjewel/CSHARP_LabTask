using System;
namespace LabTask_2
{
    class Faculty : Person
    {
        private string facultyId;
        private string joiningDate;
        private int salary;

        public Faculty()
        {
            this.facultyId = "";
            this.joiningDate = "";
            this.salary = 0;

            Console.WriteLine("Faculty Empty constructor called.");
        }
        public Faculty(string FacultyId, string JoiningDate, int Salary)
        {
            this.facultyId = FacultyId;
            this.joiningDate = JoiningDate;
            this.salary = Salary;

            Console.WriteLine("Faculty Parameterized cons called.");
        }
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

        public void FacultyStatus()
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
        }
    }
}