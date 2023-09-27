using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabOne
{
    internal class Contact
    {
        private string personName;
        private int age;
        private string mobileNumber;
        private char gender; //M or F

        public Contact(string PersonName, int Age, string MobileNumber, char Gender)
        {
            this.personName = PersonName;
            this.age = Age;
            this.mobileNumber = MobileNumber;
            this.gender = Gender;
            Console.WriteLine("Contact cons called");
            //MobileNumber
            //Gender
        }
        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public char Gender
        {
            get { return gender; }
            set
            {
                if (gender == 'M' && gender == 'F')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Other gender");
                }
            }
        }
        public void ShowContactInfo()
        {
            Console.WriteLine(GetContact());

            /*Console.WriteLine("Person Name: " + this.PersonName);
            Console.WriteLine("Person Age: " + this.Age);
            Console.WriteLine("Person MobileNumber: " + this.MobileNumber);
            Console.WriteLine("Person Gender: " + this.Gender);*/
        }
        public string GetContact()
        {
            return "Person Name: " + this.PersonName + ", Person Age: " + this.Age + ", Person Mobile Number: " + this.MobileNumber + ",Person Gender: " + this.Gender;
        }
    }
}