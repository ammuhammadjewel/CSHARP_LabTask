using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public string CourseName
        {
            set
            {
                this.courseName = value;
            }
            get
            {
                return this.courseName;
            }
        }

        public string CourseCode
        {
            set
            {
                this.courseCode = value;
            }
            get
            {
                return this.courseCode;
            }
        }

        public int CourseCredit
        {
            set
            {
                this.courseCredit = value;
            }

            get
            {
                return this.courseCredit;
            }
        }

        public Course()
        {
            Console.WriteLine("Empty Constructor Called For Course\n");
            this.courseName = "";
            this.courseCode = "";
            this.courseCredit = 0;
        }
        public Course(string a, string b, int c)
        {
            Console.WriteLine("Parameterized Constructor Called For Course\n");
            this.courseName = a;
            this.courseCode = b;
            this.courseCredit = c;
        }

        public void showCourseInfo()
        {
            Console.WriteLine("Showing Course Information:");
            Console.WriteLine("Course Name: {0}", this.courseName);
            Console.WriteLine("Course Code: {0}", this.courseCode);
            Console.WriteLine("Course Credit: {0}", this.courseCredit);
        }



    }
}