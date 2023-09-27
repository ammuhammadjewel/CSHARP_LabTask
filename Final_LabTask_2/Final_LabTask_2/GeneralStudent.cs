using System;
namespace Final_LabTask
{
    public partial class GeneralStudent : Student
    {
        public GeneralStudent(string name, int age, string address, string studentId, double cgpa, int creditcomplete) : base(name, age, address, studentId, cgpa, creditcomplete)
        {
            base.Name = name;
            base.Age = age;
            base.Address = address;
            base.StudentId = studentId;
            base.Cgpa = cgpa;
            base.CreditComplete = creditcomplete;
            Console.WriteLine("GNStrudent para cons!");
        }

        public override void StudentStatus()
        {
            Console.WriteLine("Students are in the class room");
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
        }
    }
}