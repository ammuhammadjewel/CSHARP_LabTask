using System;

namespace LabTask_3
{
    class Book
    {
        private string bookName = " ";
        private string bookAuthor = " ";
        private string bookId;
        private string bookType = " ";
        private int bookCopy;
        public int bookCount;

        public Book()
        {
            this.bookName = "";
            this.bookAuthor = "";
            this.bookId = "";
            this.bookType = "";
            this.bookCopy = 0;
            Console.WriteLine("Book cons called");
        }

        public Book(string BookName, string BookAuthor, string BookId, string BookType, int BookCopy)
        {
            this.bookName = BookName;
            this.bookAuthor = BookAuthor;
            this.bookId = BookId;
            this.bookType = BookType;
            this.bookCopy = BookCopy;
            bookCount++;
            Console.WriteLine("Book Parameterized cons called!");
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

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public void showInfo()
        {
            Console.WriteLine("Book Name: " + this.BookName);
            Console.WriteLine("Book Author: " + this.BookAuthor);
            Console.WriteLine("Boo ID: " + this.BookId);
            Console.WriteLine("book Type: " + this.BookType);
            Console.WriteLine("Book Copy: " + this.BookCopy);
        }
        public void addBookCopy(int x)
        {
            bookCount++;
            bookCount = x;

        }

    }
}
