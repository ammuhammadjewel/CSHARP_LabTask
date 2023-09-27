using System;
namespace Final_LabTask
{
    public partial class ProbationStudent : Student
    {
        private int probationSeme;
        private string counselorName;

        /*public ProbationStudent()
        {
            this.probationSeme = 0;
            this.counselorName = "";
            Console.WriteLine("Probation empty cons called");
        }*/
        public ProbationStudent(string name, int age, string address, string studentId, double cgpa, int creditComplete, int probationSeme, string counselorName) : base (name, age, address, studentId, cgpa, creditComplete)
        {
            base.Name = name;
            base.Age = age;
            base.Address = address;
            base.StudentId = studentId;
            base.Cgpa = cgpa;
            base.CreditComplete = creditComplete;
            this.probationSeme = probationSeme;
            this.counselorName = counselorName;
            Console.WriteLine("Probation para cons called");
        }
        public int ProbationSeme
        {
            get { return this.probationSeme; }
            set { this.probationSeme = value; }
        }
        public string CounselorName
        {
            get { return this.counselorName; }
            set { this.counselorName = value; }
        }
        public override void StudentStatus()
        {
            Console.WriteLine("Probation Stuatus");
        }
       
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Semester: " + this.ProbationSeme);
            Console.WriteLine("Counselor Name: " + this.CounselorName);
            //Console.WriteLine(GetProStu());
        }
    }
}