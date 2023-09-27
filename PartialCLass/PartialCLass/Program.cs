namespace PartialCLass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.Deposit();
            Console.WriteLine(acc1.Balance);

            acc1.Withdraw();
            Console.WriteLine(acc1.Balance);
        }
    }
    partial class Account
    {
        private double balance;
        public void Deposit()
        {
            Console.WriteLine("Deposit operation done!");
            this.balance++;
        }
    }
    partial class Account
    {
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Account() 
        {
            this.balance = 0;
        }
        public void Withdraw()
        {
            Console.WriteLine("Withdraw operation done!");
            this.balance--;
        }
    }

}