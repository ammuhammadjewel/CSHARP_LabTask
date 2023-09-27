using System;
namespace ClassAndObject
{
   class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course()
        {
            this.courseName = "";
            this.courseCode = "";
            this.courseCredit = 0;
            Console.WriteLine("Course cons called!");
        }

        public Course(string CoourseName, string CourseCode, int CourseCredit)
        {
            this.courseName = CoourseName;
            this.courseCode = CourseCode;
            this.courseCredit = CourseCredit;
        }

        public string CoourseName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }

        public string CourseCode
        {
            get { return this.courseCode; }
            set { this.courseCode = value; }
        }

        public int CourseCredit
        {
            get { return this.courseCredit; }
            set { this.courseCredit = value; }
        }

        public void showCourseInfo()
        {
            Console.WriteLine("Course Name: " + this.CoourseName);
            Console.WriteLine("Course Code: " + this.CourseCode);
            Console.WriteLine("Course Credit: " + this.CourseCredit);
            Console.WriteLine();
        }
    }
}