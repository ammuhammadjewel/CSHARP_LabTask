using System;
namespace StudentInfo
{
    class student
    {
        public static void Main(string[] args)
        {
            //info
            string firstName, lastName, birthDate, addressLine1, addressLine2, city, state, zip, country;
            
            Console.Write("Enter First name: "); 
            firstName = Console.ReadLine();
            Console.Write("Enter Last name: "); 
            lastName = Console.ReadLine();
            Console.Write("Enter Birth date: "); 
            birthDate = Console.ReadLine();
            Console.Write("Enter address line 1: "); 
            addressLine1 = Console.ReadLine();
            Console.Write("Enter address line 2: "); 
            addressLine2 = Console.ReadLine();
            Console.Write("Enter city naem: "); 
            city = Console.ReadLine();
            Console.Write("Enter state name: "); 
            state = Console.ReadLine();
            Console.Write("Enter zip code: "); 
            zip = Console.ReadLine();
            Console.Write("Enter country name: "); 
            country = Console.ReadLine();


            //array

            string[] student = new string[] { firstName, lastName, birthDate, addressLine1, addressLine2, city, state,zip, country };
            //int[] stundet = new int[] { zip };
            printinfo(student);

            //info loop 
            Console.WriteLine("Do you want to change the information?");
            Console.WriteLine("\n1. \"Y\" Yes.");
            Console.WriteLine("\n2. \"N\" No.");
            //char c = Convert.ToChar(value: Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            int i = 0;
            if (c == 'y')
            {
                Console.WriteLine();
                Console.WriteLine("Which information do you want to change?: \n1. AddressLine 1 \n2. AddressLine 2 \n3. City \n4. Country \n");
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    student[3] = change();
                    Console.WriteLine("Information has been updated.");
                    printinfo(student);
                }
                else if (i == 2)
                {
                    student[4] = change();
                    Console.WriteLine("Information has been updated.");
                    printinfo(student);
                }
                else if (i == 3)
                {
                    student[5] = change();
                    Console.WriteLine("Information has been updated.");
                    printinfo(student);
                }
                else if (i == 4)
                {
                    student[8] = change();
                    Console.WriteLine("Information has been updated.");
                    printinfo(student);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    printinfo(student);
                }
            }

            else if (c == 'n')
            {
                Console.WriteLine("Do you want to print the information?");
                char cc = Convert.ToChar(Console.ReadLine());
                if (cc == 'y') printinfo(student);
                else if (cc == 'n') Console.WriteLine("Thank you.");
                else Console.WriteLine("Invalid input.");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

        }

        public static string change()
        {
            string updatedinfo;
            Console.WriteLine("Enter new information: ");
            updatedinfo = Console.ReadLine();
            return updatedinfo;
        }
        public static void printinfo(string[] student)
        {
            Console.Write("First name:" + student[0]);
            Console.Write("Last name:" + student[1]);
            Console.Write("Birth date:" + student[2]);
            Console.Write("Address Line 1:" + student[3]);
            Console.Write("Address Line 2:" + student[4]);
            Console.Write("City name:" + student[5]);
            Console.Write("State name:" + student[6]);
            Console.Write("Zip code:" + student[7]);
            Console.Write("Country name:" + student[8]);
        }
    }
}