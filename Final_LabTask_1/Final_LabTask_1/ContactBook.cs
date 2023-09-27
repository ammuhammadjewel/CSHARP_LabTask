using FinalLabOne;
using System;
namespace FinaLabOne
{
    class ContactBook
    {
        private string ownerName;
        private string ownerAddress;
        private Contact[] listOfContact = new Contact[100];

        public ContactBook(string OwnerName, string OwnerAddress)
        {
            this.ownerName = OwnerName;
            this.ownerAddress = OwnerAddress;
            Console.WriteLine("Contact Book cons called");
            //listOfContact = new Contact[list];

        }
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }
        public string OwnerAddress
        {
            get { return ownerAddress; }
            set { ownerAddress = value; }
        }
        public void AddContact(Contact con)
        {
            for (int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] == null)
                {
                    listOfContact[i] = con;
                    Console.WriteLine("Contact Added");
                    break;
                }
            }
        }
        public void PrintAllContact()
        {
            for(int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] != null)
                {
                    listOfContact[i].ShowContactInfo();
                }
            }
        }
        public void ShowInfo() //show all info of contactBook and contact
        {
            Console.WriteLine("Owner Name: " +this.OwnerName);
            Console.WriteLine("Owner Address: " +this.OwnerAddress);
            PrintAllContact();
        }
    }
}
