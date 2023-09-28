using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal class Contact
    {
        private string personName;
        private string personID;
        private int age;
        private string mobileNumber;
        private char gender;

        public string PersonName
        {
            set
            {
                this.personName = value;
            }
            get
            {
                return this.personName;
            }
        }

        public string PersonID
        {
            set
            {
                this.personID = value;
            }
            get
            {
                return this.personID;
            }
        }

        public int Age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }

        public string MobileNumber
        {
            set
            {
                this.mobileNumber = value;
            }
            get
            {
                return this.mobileNumber;
            }
        }

        public char Gender
        {
            set
            {
                this.gender = value;
            }
            get
            {
                return this.gender;
            }
        }

        public Contact()
        {
            Console.WriteLine("Empty Constructor Called For Contact\n");
            this.personName = "";
            this.personID = "";
            this.age = 0;
            this.mobileNumber = "";
            this.gender = ' ';
        }
        public Contact(string a, string b, int c, string d, char e)
        {
            Console.WriteLine("Parameterized Constructor Called For Contact\n");
            this.personName = a;
            this.personID = b;
            this.age = c;
            this.mobileNumber = d;
            this.gender = e;
        }
        public void showPersonInfo()
        {
            Console.WriteLine("Showing Personal Information:");
            Console.WriteLine("Name: {0}", this.personName);
            Console.WriteLine("ID: {0}", this.personID);
            Console.WriteLine("Age: {0}", this.age);
            Console.WriteLine("Mobile Number: {0}", this.mobileNumber);

            if (this.gender == 'M' || this.gender == 'F') Console.WriteLine("Gender: {0}", this.gender);
            else Console.WriteLine("Invalid Gender");
        }

        public void detectMobileOperator()
        {
            Console.WriteLine("Detecting Mobile Operator:");
            Console.WriteLine("Mobile Number: {0}", this.mobileNumber);
            if (this.mobileNumber[2] == '7' || this.mobileNumber[2] == '3') Console.WriteLine("Mobile Operator: Grameenphone");
            else if (this.mobileNumber[2] == '9' || this.mobileNumber[2] == '4') Console.WriteLine("Mobile Operator: Banglalink");
            else if (this.mobileNumber[2] == '5') Console.WriteLine("Mobile Operator: Teletalk");
            else if (this.mobileNumber[2] == '6') Console.WriteLine("Mobile Operator: Airtel");
            else if (this.mobileNumber[2] == '6') Console.WriteLine("Mobile Operator: Airtel");
            else if (this.mobileNumber[2] == '8') Console.WriteLine("Mobile Operator: Robi");
            else Console.WriteLine("Mobile Operator: Other");
        }
    }
}