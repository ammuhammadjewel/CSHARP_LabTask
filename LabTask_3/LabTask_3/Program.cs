using System;
using System.IO.Pipes;

namespace LabTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Course coursee = new Course();
            Course course = new Course("OOP2", "a11", 3);

            course.showCourseInfo();
            Console.WriteLine();



            Book bookk = new Book();
            Book book = new Book("c-sharp", "library", "a12", "programing language", 2);

            book.addBookCopy(20);
            book.showInfo();
            Console.WriteLine();


            Course contactt = new Course();
            Contact contact = new Contact("book", "a55", 20, "01531111111", 'M');
            contact.showPersonInfo();
            contact.detectMobileOperator();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}