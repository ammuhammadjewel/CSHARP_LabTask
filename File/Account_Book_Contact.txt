using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Account
    {
        private string accName, acid;
        private double balance;

        public string AccName
        {
            set { this.accName = value; }
            get { return this.accName; }
        }
        public string AccId
        {
            set { this.acid = value; }
            get { return this.acid; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }


        public Account()
        {
            Console.WriteLine("Empty Account Constructor");
        }
        public Account(string a, string b, double c)
        {
            Console.WriteLine("Valued Account Constructor");
            accName = a;
            acid = b;
            balance = c;
        }
        public void Deposite(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount Deposited");
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;
            Console.WriteLine("Amount Withdrawn");
        }
        public void Transfer(double amount, Account reciever)
        {
            reciever.balance = amount;
            Console.WriteLine("Amount Transfered");
        }


    }
}










using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Book
    {
        private string bookName, bookAuthor, bookId, bookType;
        private int bookcopy;
        private static int bookCounter=0;
        
        public Book()
        {
            Console.WriteLine("Empty Book Constructor");
        }
        public Book(string a, string b, string c, string d, int e)
        {
            bookName = a;
            bookAuthor = b;
            bookId = c;
            bookType = d;
            bookcopy=e;
            bookCounter=bookCounter+bookcopy;
            Console.WriteLine("Valued Book Constructor");
        }
        
        public void AddBookCopy(int x)
        {
            bookcopy = bookcopy + x;
            bookCounter = bookCounter + x;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book name: {0}\nBook Author:{1}\n Book Id: {2}\n Book Type:{3}\nBook Copy: {4}", bookName, bookAuthor, bookId, bookType, bookcopy);
        }
        public static void ShowTotalBookInfo()
        {
            Console.WriteLine("Total Number of Books {0}",bookCounter);
        }



    }
}


















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Contact
    {
        private string personName, personId, mobileNumber;
        private int age;
        private char gender;

        public Contact()
        {
            Console.WriteLine("Empty Contact Constructor");
        }
        public Contact(string a, string b, int c, string d, char e)
        {
            Console.WriteLine("Valued Contact Constructor");
            personName = a;
            personId = b;
            age = c;
            mobileNumber = d;
            gender = e;
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("Person Name: {0}\nPerson Id: {1}\nAge: {2}\nMobile Number:{3}\nGender: {4}",personName, personId,age, mobileNumber,gender);
        }
        public void DetectMobileOperator()
        {
            if(mobileNumber[2].Equals('7'))
            {
                Console.WriteLine("GP Number");
            }
            else if(mobileNumber[2].Equals('9'))
            {
                Console.WriteLine("Banglalink Number");
            }
            else if(mobileNumber[2].Equals('8'))
            {
                Console.WriteLine("Robi Number");
            }
            else if(mobileNumber[2].Equals('6'))
            {
                Console.WriteLine("Airtel Number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }


        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Account a2 = new Account("ABC", "001", 1000.0);

            a2.Deposite(1000.0);
            a2.Withdraw(500.0);
            a2.Transfer(500.0, a1);

            Console.WriteLine("\n");
            Book b1 = new Book();
            Book b2 = new Book("Let us c", "X", "101", "Coding", 10);

            
            b2.AddBookCopy(20);
            b2.ShowInfo();
            Book.ShowTotalBookInfo();

            Console.WriteLine("\n");

            Contact c1 = new Contact();
            Contact c2 = new Contact("XYZ", "201", 21, "01911111111", 'M');

            c2.ShowPersonInfo();

            c2.DetectMobileOperator();


        }
    }
}




*************************************


namespace Contact
{
    class Contact
    {
        private string personName, personId , mobileNumber;
        private char gender; 
        private int age;

    public Contact()
    {
        this.personName = "";
        this.personId = "";
        this.mobileNumber = "";
        this.gender = '\0';
        this.age = 0;

    }
    public Contact(string personName, string personId, string mobileNumber,char gender, int age)
    { 
          this.personName =personName ;
               this.personId =personId;
                this. mobileNumber = mobileNumber;
                this.gender=gender;
                this.age=age;

    }
    public void SetPersonName(string personName)
    {
        this.personName = personName;
    }
    public void SetPersonId(string personId)
    {
        this.personId = personId;
    }
    public void  SetMobileNumber(string mobileNumber)
    {
         this. mobileNumber = mobileNumber;
    }
    public void SetGender(char gender)
    {
        this.gender = gender;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public string GetPersonName()
    {
        return this.personName;
    }
    public string GetPersonId()
    {
        return this.personId;
    }
    public string GetMobileNumber()
    {
        return this.mobileNumber;
    }
    public char GetGender()
    {
        return this.gender;
    }
    public int GetAge()
    {
        return this.age;
    }
   public void DetectMobileOperator()
    {


        if (this.mobileNumber[2] == 7)
        {
            Console.WriteLine("Gp");
        }
        else if (this.mobileNumber[2] == 9)
        {
            Console.WriteLine("Banglalink");
        }
        else if (this.mobileNumber[2] == 8)
        {
            Console.WriteLine("Robi");
        }


    }
   public void ShowPersonInfo()
   {
       Console.WriteLine("PersonName: {0}\npersonId: {1}\nMobilenumber: {2}\nGender: {3}\nAge: {4}", this.personName, this.personId, this.mobileNumber, this.gender,this.age);
   }




}
}

namespace Contact
{
    class Program
    {
        static void Main(string[] args)
        {
         Contact c = new Contact("jerin","14255581","01782813945",'F',22);

        c.ShowPersonInfo();
        c.DetectMobileOperator();



    }
}
}