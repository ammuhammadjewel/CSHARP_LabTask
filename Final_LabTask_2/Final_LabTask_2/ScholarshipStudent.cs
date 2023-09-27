using System;
namespace Final_LabTask
{
    public partial class ScholarshipStudent : Student
    {
        private string schoAmount;

        /*public ScholarshipStudent()
        {
            this.schoAmount = "";
            Console.WriteLine("Scholarship students empty cons called");
        }*/
        public ScholarshipStudent(string name, int age, string address, string studentId, double cgpa, int creditComplete, string schoAmount) : base (name, age, address, studentId, cgpa, creditComplete)
        {
            base.Name = name;
            base.Age = age;
            base.Address = address;
            base.StudentId = studentId;
            base.Cgpa = cgpa;
            base.CreditComplete = creditComplete;
            this.schoAmount = SchoAmount;
            Console.WriteLine("Scholarship student para cons called");
        }
        public string SchoAmount
        {
            get { return this.schoAmount; }
            set { this.schoAmount = value; }
        }
        public override void StudentStatus()
        {
            Console.WriteLine("Scholarship Student Status");
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Scholarship ammount: " + this.SchoAmount);
        }
    }
}