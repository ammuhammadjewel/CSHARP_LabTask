using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_Student
{
    public abstract class Student
    {
        private string name;
        private string id;
        private double cgpa;
        public Student(string name, string id, double cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public double Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        public abstract void ShowStudentInfo();
    }
    public class GeneralStudent : Student
    {
        private int semeComplete;
        private int creditComplete;
        public GeneralStudent(string name, string id, double cgpa, int semeComplete, int creditComplete) : base(name, id, cgpa)
        {
            base.Name = name;
            base.Id = id;
            base.Cgpa = cgpa;
            this.semeComplete = semeComplete;
            this.creditComplete = creditComplete;
        }
        public int SemeComplete
        {
            set { semeComplete = value; }
            get { return semeComplete; }
        }
        public int CeditComplete
        {
            set { creditComplete = value; }
            get { return creditComplete; }
        }
        public override void ShowStudentInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("CGPA: " + Cgpa);
            Console.WriteLine("Semester Completed: " + SemeComplete);
            Console.WriteLine("Credit Completed: " + creditComplete);
        }
    }
    public class ScholarshoipStudent : Student
    {
        int semeComplete;
        int creditComplete;
        int percentage;
        public ScholarshoipStudent(string name, string id, double cgpa, int semeComplete, int creditComplete, int percentage) : base(name, id, cgpa)
        {
            base.Name = name;
            base.Id = id;
            base.Cgpa = cgpa;
            this.semeComplete = semeComplete;
            this.creditComplete = creditComplete;
            this.percentage = percentage;
        }
        public int SemeComplete
        {
            set { semeComplete = value; }
            get { return semeComplete; }
        }
        public int CeditComplete
        {
            set { creditComplete = value; }
            get { return creditComplete; }
        }
        public int Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }
        public override void ShowStudentInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("CGPA: " + Cgpa);
            Console.WriteLine("Semester Completed: " + SemeComplete);
            Console.WriteLine("Credit Completed: " + creditComplete);
            Console.WriteLine("Percentage: " + Percentage);
        }
    }
    public class CS_Dept : GSCalculation, SSCalculation
    {
        private int totalCredit;
        private int creditCost;
        private GeneralStudent[] generalStd = new GeneralStudent[100];
        private ScholarshoipStudent[] schoStd = new ScholarshoipStudent[100];
        public CS_Dept(int totalCredit, int creditCost, GeneralStudent[] generalStd, ScholarshoipStudent[] schoStd)
        {
            this.totalCredit = totalCredit;
            this.creditCost = creditCost;
            this.generalStd = generalStd;
            this.schoStd = schoStd;
        }
        public int TotalCredit
        {
            set { totalCredit = value; }
            get { return totalCredit; }
        }
        public int CreditCost
        {
            set { creditCost = value; }
            get { return creditCost; }
        }
        public GeneralStudent[] GeneralStd
        {
            set { generalStd = value; }
            get { return generalStd; }
        }
        public ScholarshoipStudent[] SchoStd
        {
            set { schoStd = value; }
            get { return schoStd; }
        }
        public void ShowDeptInfo()
        {
            Console.WriteLine("Depertment Name: Compuer Science and Engineering.");
            Console.WriteLine("Total Credits: " + TotalCredit);
            Console.WriteLine("Credit Cost: " + CreditCost);
        }
        public void AddGeneralStudent(GeneralStudent std)
        {
            for (int i = 0; i < 100; i++)
            {
                if (generalStd[i] == null)
                {
                    generalStd[i] = std;
                }
            }
        }
        public void AddScholarshipStudent(ScholarshoipStudent std)
        {
            for (int i = 0; i < 100; i++)
            {
                if (schoStd[i] == null)
                {
                    schoStd[i] = std;
                }
            }
        }
        public void GSTotalCost()
        {
            double total;
            total = totalCredit * creditCost;
            Console.WriteLine("Total Cost For General Student: " + total);
        }
        public void SSTotalCost()
        {
            int i;
            double total, tc;
            tc = (totalCredit * creditCost) * (100 / schoStd[0].Percentage);
            total = (totalCredit * creditCost) - tc;
            Console.WriteLine("Total Cost: " + total);
        }
        public void ShowGeneralStudentInfo()
        {
            generalStd[0].ShowStudentInfo();
        }
        public void ShowScholarshipStudentInfo()
        {
            schoStd[0].ShowStudentInfo();
        }
        public void finaltialDetails()
        {
            SSTotalCost();
            GSTotalCost();
        }
    }
    public class Varsity
    {

    }
    public interface GSCalculation
    {
        void GSTotalCost();
    }
    public interface SSCalculation
    {
        void SSTotalCost();
    }
    class Program
    {
        static void Main(string[] args)
        {
            GeneralStudent g1 = new GeneralStudent("Student", "a10", 3.5, 7, 90);
            g1.ShowStudentInfo();
            ScholarshoipStudent s1 = new ScholarshoipStudent("SStudent", "a11", 3.9, 9, 110, 86);
            s1.ShowStudentInfo();

            
        }
    }
}
