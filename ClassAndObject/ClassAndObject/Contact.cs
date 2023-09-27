using System;
using System.Diagnostics;

namespace ClassAndObject
{
    class Contact
    {
        private string personName;
        private string personID;
        private int age;
        private string mobileNumber;
        private char gender;

        public Contact()
        {
            this.personName = " ";
            this.personID = "";
            this.age = 0;
            this.mobileNumber = "";
            this.gender = 'M'; 
            Console.WriteLine("Contact cons called");
            
        }

        public Contact(string PersonName, string PersonID, int Age, string MobileNumber, char Gender)
        {
            this.personName = PersonName;
            this.personID = PersonID;
            this.age = Age;
            this.mobileNumber = MobileNumber;
            this.gender = Gender;

            Console.WriteLine("Perameterized cons called");
        }

        public string PersonName
        {
            get { return this.personName; }
            set { this.personName = value; }
        }
        public string PersonID
        {
            get { return this.personID; }
            set { this.personID = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string MobileNumber
        {
            get { return this.mobileNumber; }
            set { this.mobileNumber = value; }
        }

        public char Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        
        
        public void showPersonInfo()
        {
            Console.WriteLine("Person Name: " +this.PersonName);
            Console.WriteLine("Person ID: " +this.PersonID);
            Console.WriteLine("Person age: " +this.Age);
            Console.WriteLine("Person mobile number: " +this.MobileNumber);
            Console.WriteLine("Gender: " + this.Gender);
        }
        public void detectMobileOperator()
        {
            if (this.mobileNumber[3] == 7)
            {
                Console.WriteLine("GP");
            }
            else if (this.mobileNumber[3] == 8)
            {
                Console.WriteLine("Robi");
            }
            else if (this.mobileNumber[3] == 5)
            {
                Console.WriteLine("Teletalk");
            }
            else if (this.mobileNumber[3] == 9)
            {
                Console.WriteLine("Banglalink");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
