using System;
namespace LabTask
{
    class Course
    {
        public string courseName;
        private string courseCode;
        public int courseCredit;

        public Course()
        {
            courseCode = " ";
            Console.WriteLine("Corse code cons called");
        }
    }
    class Book
    {
        public string bookName = " ";
        private string bookAuthor;
        public string bookType = " ";
        public int bookCopy;
        public Book()
        {
            bookAuthor = " ";
            Console.WriteLine("Book cons called");
        }
    }
    class Contact
    {
        public string personName;
        private string personID = " ";
        public int age;
        public string mobileNumber;
        public char gender;

        public Contact()
        {
            personID = " ";
            Console.WriteLine("Contact class cons called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course()
            {

            };

            Book book = new Book()
            {

            };

            Contact contact = new Contact()
            {

            };
        }
    }
}