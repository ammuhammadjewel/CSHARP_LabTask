using Final_LabTask;
using System;
namespace Final_LabTasl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Faculty();




            Console.WriteLine("|| FulltimeFaculty ||");
            
            Faculty ff = new FulltimeFaculty("faculty", 30, "kuratuli", "a10", "04-12-2022", 1500000, "01-01-2023");
            ff.PerosnSatus();
            ff.FacultySatus();
            ((FulltimeFaculty)ff).PerosnSatus();
            ff.ShowDetails();
            Console.WriteLine();


            Console.WriteLine("|| Contractual ||");
            
            Faculty fc = new ContractulaFaculty("ConFaculty", 28, "kuratuli", "a12", "04-12-2022", 2000000, "6");
            fc.PerosnSatus();
            fc.FacultySatus();
            ((ContractulaFaculty)fc).PerosnSatus();
            fc.ShowDetails();
            Console.WriteLine();

            Console.WriteLine("|| Student ||");
            
            Student gs = new GeneralStudent("Student", 20, "kuratuli", "s10", 3.5, 73);
            gs.PerosnSatus();
            gs.StudentStatus();
            ((GeneralStudent)gs).PerosnSatus();
            gs.StudentStatus();
            Console.WriteLine();

            Console.WriteLine("|| Scholarship Student ||");
            
            Student ss = new ScholarshipStudent("SchStudent", 21, "kuratuli", "s11", 3.9, 110, "2000000");
            ss.StudentStatus();
            ((ScholarshipStudent)ss).StudentStatus();
            ss.ShowDetails();
            Console.WriteLine();

            Console.WriteLine("|| Probation Student ||");
            
            Student ps = new ProbationStudent("ProStudent", 22, "kuratuli","a12", 2.4, 130, 11, "counselor");
            ps.PerosnSatus();
            ps.StudentStatus();
            ((ProbationStudent)ps).StudentStatus();
            ps.ShowDetails();

            Console.ReadKey();
        }
    }
}