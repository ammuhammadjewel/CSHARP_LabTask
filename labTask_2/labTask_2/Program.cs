using System;
namespace Program
{
    class student
    {
        public static void Main(string[] args)
        {
            int n = 0;

            //taking the inputs

            string fname, lname, bd, ad1, ad2, city, state, zip, country;
            Console.Write("Enter first name: "); fname = Console.ReadLine();
            Console.Write("Enter last name: "); lname = Console.ReadLine();
            Console.Write("Enter birth date: "); bd = Console.ReadLine();
            Console.Write("Enter address 1: "); ad1 = Console.ReadLine();
            Console.Write("Enter address 2: "); ad2 = Console.ReadLine();
            Console.Write("Enter city: "); city = Console.ReadLine();
            Console.Write("Enter state: "); state = Console.ReadLine();
            Console.Write("Enter zip code: "); zip = Console.ReadLine();
            Console.Write("Enter country: "); country = Console.ReadLine();


            //making the array

            string[] student = new string[9] { fname, lname, bd, ad1, ad2, city, state, zip, country };
            printinfo(student);


            // asking if wants to change the info
            Console.WriteLine("Do you want to change the information? (enter y for yes or n for no) ");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'y')
            {
                Console.WriteLine("Which information do you wanna change?: \n1. Address 1 \n2. Address 2 \n3. City \n4. Country \n");
                n = Convert.ToInt16(Console.ReadLine());
                if (n == 1)
                {
                    student[3] = change();
                    Console.WriteLine("Information updated.");
                    printinfo(student);
                }
                else if (n == 2)
                {
                    student[4] = change();
                    Console.WriteLine("Information updated.");
                    printinfo(student);
                }
                else if (n == 3)
                {
                    student[5] = change();
                    Console.WriteLine("Information updated.");
                    printinfo(student);
                }
                else if (n == 4)
                {
                    student[8] = change();
                    Console.WriteLine("Information updated.");
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
                Console.WriteLine("Do you wanna print the information? (enter y for yes or n for no)");
                char d = Convert.ToChar(Console.ReadLine());
                if (d == 'y') printinfo(student);
                else if (d == 'n') Console.WriteLine("Thank you for your info");
                else Console.WriteLine("Invalid input.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

        }

        public static string change()
        {
            string updatedinfo;
            Console.WriteLine("enter the new information: ");
            updatedinfo = Console.ReadLine();
            return updatedinfo;
        }
        public static void printinfo(string[] stud)
        {
            Console.Write("the first name is:" + stud[0] + "\n");
            Console.Write("the last name is:" + stud[1] + "\n");
            Console.Write("the birth date is:" + stud[2] + "\n");
            Console.Write("the address 1 is:" + stud[3] + "\n");
            Console.Write("the address 2 is:" + stud[4] + "\n");
            Console.Write("the city is:" + stud[5] + "\n");
            Console.Write("the state is:" + stud[6] + "\n");
            Console.Write("the zip code is:" + stud[7] + "\n");
            Console.Write("the country is:" + stud[8] + "\n");
        }
    }
}