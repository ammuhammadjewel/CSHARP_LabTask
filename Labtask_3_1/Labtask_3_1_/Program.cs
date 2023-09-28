using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Course Class|\n");
            Course c1 = new Course("Object Oriented Programming 2", "C#", 3);
            Course c2 = new Course();

            c2.CourseName = "Object Oriented Programming 1";
            c2.CourseCode = "JAVA";
            c2.CourseCredit = 3;

            c1.showCourseInfo();
            Console.WriteLine();
            c2.showCourseInfo();

            Console.WriteLine();

            Console.WriteLine("|Book Class|\n");
            Book b1 = new Book("The Institute", "Stephen King", "1XDH6", "Horror", 7);
            Book b2 = new Book();

            b1.addBookCopy(10);

            b2.BookName = "The Da Vinci Code";
            b2.BookAuthor = "Dan Brown";
            b2.BookId = "2XDHG5";
            b2.BookType = "Thriller";
            b2.BookCopy = 8;

            b2.addBookCopy(20);

            b1.showInfo();
            Console.WriteLine();
            b2.showInfo();
            Console.WriteLine();
            Console.WriteLine("Number Of Book Objects Created: {0}", Book.bookCounter);

            Console.WriteLine();

            Console.WriteLine("|Contact Class|\n");
            Contact co1 = new Contact("Stephen King", "2XDOG5", 60, "01793498251", 'M');
            Contact co2 = new Contact();

            co2.PersonName = "Dan Brown";
            co2.PersonID = "6XGFR2";
            co2.Age = 58;
            co2.MobileNumber = "01588665966";
            co2.Gender = 'M';

            co1.showPersonInfo();
            Console.WriteLine();
            co1.detectMobileOperator();
            Console.WriteLine();
            co2.showPersonInfo();
            Console.WriteLine();
            co2.detectMobileOperator();
            Console.WriteLine();
        }
    }
}
