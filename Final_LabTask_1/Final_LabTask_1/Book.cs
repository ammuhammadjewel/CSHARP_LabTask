using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabOne
{
    internal class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        public Book(string BookName, string BookAuthor, string BookId, string BookType)
        {
            this.bookName = BookName;
            this.bookAuthor = BookAuthor;
            this.bookId = BookId;
            this.bookType = BookType;
            Console.WriteLine("Book constructor called.");
        }
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        public string GetBook()
        {
            return "Book name: " + this.bookName + ", Book Author: " + this.BookAuthor + ", Book id: " + this.BookId + ",Book Type: " + this.BookType;
        }
        public void ShowBookInfo()
        {
            Console.WriteLine(GetBook());
        }
    }
}
