using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        public static int bookCounter = 0;

        public string BookName
        {
            set
            {
                this.bookName = value;
            }
            get
            {
                return this.bookName;
            }
        }

        public string BookAuthor
        {
            set
            {
                this.bookAuthor = value;
            }
            get
            {
                return this.bookAuthor;
            }
        }

        public string BookId
        {
            set
            {
                this.bookId = value;
            }
            get
            {
                return this.bookId;
            }
        }

        public string BookType
        {
            set
            {
                this.bookType = value;
            }
            get
            {
                return this.bookType;
            }
        }

        public int BookCopy
        {
            set
            {
                this.bookCopy = value;
            }
            get
            {
                return this.bookCopy;
            }
        }
        public Book()
        {
            Console.WriteLine("Empty Constructor Called For Book\n");
            this.bookName = "";
            this.bookAuthor = "";
            this.bookId = "";
            this.bookType = "";
            this.bookCopy = 0;
            bookCounter++;
        }
        public Book(string a, string b, string c, string d, int e)
        {
            Console.WriteLine("Parameterized Constructor Called For Book\n");
            this.bookName = a;
            this.bookAuthor = b;
            this.bookId = c;
            this.bookType = d;
            this.bookCopy = e;
            bookCounter++;
        }

        public void addBookCopy(int x)
        {
            if (x > 0) this.bookCopy += x;
            else Console.WriteLine("Invalid Amount");
        }
        public void showInfo()
        {
            Console.WriteLine("Showing Book Information:");
            Console.WriteLine("Book Name: {0}", this.bookName);
            Console.WriteLine("Book Author: {0}", this.bookAuthor);
            Console.WriteLine("Book ID: {0}", this.bookId);
            Console.WriteLine("Book Type: {0}", this.bookType);
            Console.WriteLine("Number of Copies: {0}", this.bookCopy);
        }
    }
}
