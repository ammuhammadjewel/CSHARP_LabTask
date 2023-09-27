using System;
using System.Runtime.CompilerServices;

namespace LabTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person = new Person("aaa", 25, "badda");

            Console.WriteLine();

            Faculty faculty1 = new Faculty();
            Faculty faculty = new Faculty();
            faculty.FacultyStatus();
            faculty.ShowDetails();
            Console.WriteLine();

            Fulltime_faculty fulltime_Faculty1 = new Fulltime_faculty();
            Fulltime_faculty fulltime_Faculty = new Fulltime_faculty();
            fulltime_Faculty.FacultyStatus();
            fulltime_Faculty.ShowDetails();
            Console.WriteLine();

            Contratual_faculty contratual_Faculty1 = new Contratual_faculty();
            Contratual_faculty contratual_Faculty = new Contratual_faculty();
            contratual_Faculty.FacultyStatus();
            contratual_Faculty.ShowDetails();
            Console.WriteLine();
        }
    }
}