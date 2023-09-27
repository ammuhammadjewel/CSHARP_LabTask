using System;
using System.IO.Pipes;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("OOP2", "a11", 3);
            course.showCourseInfo();
            Console.WriteLine();

            Book book = new Book("c-sharp", "library", "a12", "programing language", 2);
            
            //Book.addBookCopy();
            book.showInfo();
            Console.WriteLine();
            

            Contact contact = new Contact("book", "a55", 20, "01831111111",'M');
            contact.showPersonInfo();
            Console.WriteLine();
            

            Console.ReadKey();
        }
    }
}