using FinaLabOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("book", "book author", "a13", "oop2");
            string book = b1.GetBook();
            Console.WriteLine(book);
            b1.ShowBookInfo();
            Console.WriteLine();

            Library l1 = new Library("Library", "address"); 
            l1.AddNewBook(b1);
            l1.ShowLibInfo();
            Console.WriteLine();

            Contact c1 = new Contact("Person", 20, "01555555555", 'M');
            string contact = c1.GetContact();
            Console.WriteLine(contact);
            c1.ShowContactInfo();
            Console.WriteLine();

            ContactBook cb1 = new ContactBook("Contact", "Address");
            cb1.AddContact(c1);
            cb1.ShowInfo();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}