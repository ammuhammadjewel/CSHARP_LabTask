using System;

namespace FinalLabOne
{
    internal class Library
    {
        private string libName;
        private string libAddress;
        private Book[] listOfBook = new Book[100]; //association

        public Library(string LibName, string LibAddress)
        {
            this.libName = LibName;
            this.libAddress = LibAddress;
            //listOfBook = new Book[size];
            Console.WriteLine("Library constructor called");
        }
        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        


        public void AddNewBook(Book book)
        {
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] == null)
                {
                    listOfBook[i] = book;
                    Console.WriteLine("Book added");
                    break;
                }
            }
        }
        public void PrintAllBook()
        {
            for (int i =0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] != null)
                    listOfBook[i].ShowBookInfo();
            }
        }
        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name: " + this.LibName);
            Console.WriteLine("Library Address: " + this.LibAddress);
            PrintAllBook();

        }
    }
}
