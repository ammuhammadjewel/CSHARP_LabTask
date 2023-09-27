using System;
namespace Program
{
    internal class Account //parent class or base class
    {
        private string accName;
        private string accId;
        private int balance;
        private string branchName;


        public Account() //constructor 1,,,
        {
            Console.WriteLine("Cons Called Account");
            this.accName = "";
            this.accId = "";
            this.balance = 0;
            this.branchName = "";
        }

        public Account(string AccName, string AccId, int Balance, string BranchName) //parameterized constructor
        {
            Console.WriteLine("Parameterized Consr Called Account");
            this.accName = AccName;
            this.accId = AccId;
            this.balance = Balance;
            this.branchName = BranchName;
        }

        public string AccName //set get method
        {
            set
            {
                this.accName = value;
            }
            get
            {
                return this.accName;
            }
        }
        public string AccId
        {
            set
            {
                this.accId = value;
            }
            get
            {
                return this.accId;
            }
        }

        public int Balance
        {
            set
            {
                if (value < 0)
                {
                    this.balance = 0;
                }
                else
                {
                    this.balance = value;
                }
            }
            get
            {
                return this.balance;
            }
        }

        public string BranchName
        {
            set
            {
                this.branchName = value;
            }
            get
            {
                return this.branchName;
            }
        }


       
        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount.");
            }
            else
            {
                Console.WriteLine("Deposit Successful.");
                this.balance += amount;
            }
        }

        public void Withdraw(int amount)
        {
            if ((this.balance - amount) >= 0)
            {
                Console.WriteLine("Withdraw Successful.");
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount.");
            }
        }

        public void Showbalance()
        {
            Console.WriteLine("Account Balance: {0} BDT", this.balance);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountt = new Account();
            Account accounnt = new Account("aaa", "a11", 1000, "dhaka");

            Console.WriteLine("Account Name: {0}", accounnt.AccName);
            Console.WriteLine("Account ID: {0}", accounnt.AccId);
            Console.WriteLine("Account Balance: {0}", accounnt.Balance);
            Console.WriteLine("Account Branch: {0}", accounnt.BranchName);

            accounnt.Deposit(2000);
            accounnt.Showbalance();
            accounnt.Withdraw(3000);
            accounnt.Showbalance();
        }
    }
}