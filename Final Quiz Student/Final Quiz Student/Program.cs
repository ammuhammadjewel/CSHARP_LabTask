using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fquiz_1
{
    public class Faculty
    {
        private string name;
        private string id;
        private string address;

        public Faculty(string name, string id, string address)
        {
            this.name = name;
            this.id = id;
            this.address = address;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void ShowFacultyInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Address: " + Address);
        }
        //public abstract void FFYearlyIncome();
    }


    public class FulltimeFaculty : Faculty
    {
        private string joiningDate;
        private double salary;

        public FulltimeFaculty(string name, string id, string address, string joiningDate, double salary) : base(name, id, address)
        {
            base.Name = name;
            base.Id = id;
            base.Address = address;
            this.joiningDate = joiningDate;
            this.salary = salary;
        }
        public string JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void ShowFulltimeFacultyInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Joining Date: " + JoiningDate);
            Console.WriteLine("Salary: " + Salary);
        }

        /*public override void FFYearlyIncome()
        {
            Console.WriteLine();
        }*/
        //CFIncome void CFTotalIncome
    }

    public class ContractualFaculty : Faculty
    {
        private string joiningDate;
        private int salary;
        private int duration;

        public ContractualFaculty(string name, string id, string address, string joiningDate, int salary, int duration) : base(name, id, address)
        {
            base.Name = name;
            base.Id = id;
            base.Address = address;
            this.joiningDate = joiningDate;
            this.salary = salary;
            this.duration = duration;
        }

        public string JoiningDate
        {
            get { return joiningDate;}
            set { joiningDate = value; }
        }

        public int Salary
        {
            get { return salary;}
            set { salary = value; }
        }

        public int Duration
        {
            get { return duration;}
            set { duration = value; }
        }

        /*public override void FFYearlyIncome()
        {
            throw new NotImplementedException();
        }*/

        public void ShowConstractualFacultyInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Joining Date: " + JoiningDate);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Duration: " + Duration);
        }

        //CFIncome  void CFTotalIncome
    }

    public class CS_Dept : Faculty
    {
        private int totalCredit;
        private int creditCost;

        private FulltimeFaculty[] fFaculty = new FulltimeFaculty[100];
        private ContractualFaculty[] cFaculty = new ContractualFaculty[100];

        public CS_Dept(string name, string id, string address, int totalCredit, int creditCost) : base(name, id, address)
        {
            base.Name = name;
            base.Id = id;
            base.Address = address;
            this.totalCredit = totalCredit;
            this.creditCost = creditCost;
        }
        public int TotalCredit
        {
            get { return totalCredit;}
            set { totalCredit = value; }
        }

        public int CreditCost
        {
            get { return creditCost;}
            set { creditCost = value; }
        }

        public void showDeptInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Total Credit: " + TotalCredit);
            Console.WriteLine("Name: " + CreditCost);
        }

        public void AddFulltimeFaculty(FulltimeFaculty ff)
        {
            for (int i = 0; i < fFaculty.Length; i++)
            {
                if (fFaculty[i] == null)
                {
                    fFaculty[i] = ff;
                }
            }
        }

        public void ShowFulltimeFacultyInfo()
        {
            for (int i = 0; i < fFaculty.Length; i++)
            {
                if (fFaculty[i] != null)
                {
                    fFaculty[i].ShowFulltimeFacultyInfo();
                }
            }
        }

        public void showFulltimeFacultyIncomeInfo()
        {
            //
        }

        public void AddContractulaFaculty(ContractualFaculty fFaculty)
        {
            for (int i = 0; i < cFaculty.Length; i++)
            {
                if (cFaculty[i] == null)
                {
                    cFaculty[i] = fFaculty;
                }
            }
        }

        public void ShowContractualFacultyInfo()
        {
            for (int i = 0; i < cFaculty.Length; i++)
            {
                if (cFaculty[i] != null)
                {
                    cFaculty[i].ShowConstractualFacultyInfo();
                }
            }
        }

        public void ShowConstractualFacultyIncomeInfo()
        {
            //
        }
    }

    public class Versity // : CS_Dept
    {
        private string name;
        private string address;

        CS_Dept csdept;

        public Versity(string name, string address, CS_Dept csdept)
        {
            this.name = name;
            this.address = address;
            this.csdept = csdept;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public CS_Dept CSdept
        {
            get { return csdept;}
            set { csdept = value; }
        }

        public void PrintVarsityInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Name: " + CSdept);
        }

        public void PrintCSDeptInfo()
        {
            //
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Faculty f = new Faculty("Faculty", "a10", "aiub");
            f.ShowFacultyInfo();
            Console.WriteLine();

            FulltimeFaculty ff = new FulltimeFaculty("FFaculty", "a11", "aiub", "12-01-2022", 200000.00);
            ff.ShowFulltimeFacultyInfo();
            Console.WriteLine();

            ContractualFaculty cf = new ContractualFaculty("CFaculty", "a12", "aiub", "12-01-2022", 150000, 5);
            cf.ShowConstractualFacultyInfo();
            Console.WriteLine();

            CS_Dept cd = new CS_Dept("CSdept", "a13", "aiub", 148, 90);
            cd.showDeptInfo();
            cd.ShowFulltimeFacultyInfo();
            cd.showFulltimeFacultyIncomeInfo();
            cd.ShowContractualFacultyInfo();
            cd.ShowConstractualFacultyIncomeInfo();
            Console.WriteLine();


            Versity v = new Versity("versity", "kuratoli", cd);
            v.PrintVarsityInfo();
            v.PrintCSDeptInfo();

            Console.ReadLine();
        }
    }
}