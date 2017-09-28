using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalStudentCountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aSchool = new School("EC Utbildning");
            var SPO15 = new Class("MVC", 30);
            var SPO16 = new Class("C#",27);
            var SPO17 = new Class("C++",32);
            var INP17 = new Class("Java",32);

            aSchool.aClass.Add(SPO16);
            aSchool.aClass.Add(SPO17);
            aSchool.aClass.Add(SPO17);
            aSchool.aClass.Add(INP17);
           
            Console.WriteLine($"{aSchool} has four class and total number of students are {aSchool.numberOfStudents}");
            Console.ReadLine();
        }
    }
}
