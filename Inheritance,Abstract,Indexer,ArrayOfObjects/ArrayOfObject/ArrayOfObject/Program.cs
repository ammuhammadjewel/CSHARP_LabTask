using System;
namespace ArrayOfObject
{
    class Account
    {
        private int accNum;
        private string accName;
        private double balance;
        public string branch = " ";
        public Account()
        {
            accNum = 0;
            accName = " ";
            balance = 0;
            Console.WriteLine("Default cons called!");
        }
        public int AccNum
        {
            set
            {
                if (value < 0)
                    this.accNum = 0;
                else
                    this.accNum = value;
            }
            get { return accNum; }
        }
        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public double Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Number:" + this.AccNum);
            Console.WriteLine("Account Name:" + this.AccName);
            Console.WriteLine("Account Balance:" + this.Balance);
            Console.WriteLine("Branch Name:" + this.branch);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account()
            {
                AccNum = -6,
                AccName = "Rakib",
                Balance = 1250,
                branch = "Banani"
            };
            acc1.ShowInfo();
            Console.WriteLine();

            Account acc2 = new Account()
            {
                AccNum = 1,
                AccName = "Sumon",
                Balance = 1480,
                branch = "Banani"
            };
            acc2.ShowInfo();
            Console.WriteLine();

            Account acc3 = new Account()
            {
                AccNum = 2,
                AccName = "Hasib",
                Balance = 1900,
                branch = "Gulshan"
            };
            acc3.ShowInfo();
            Console.WriteLine();

            //Array of objects
            Account[] obj1 = new Account[3];
            obj1[0] = acc1;
            obj1[1] = acc2;
            obj1[2] = acc3;

            foreach (Account obj2 in obj1)
            {
                if (obj2.branch == "Banani")
                {
                    obj2.ShowInfo();
                    Console.WriteLine("****************");
                }
            }

            Console.ReadKey();
        }
    }
}