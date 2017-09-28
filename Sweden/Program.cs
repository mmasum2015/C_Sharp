using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var thesudent = Student.GetStudentInfo();
            Console.WriteLine(thesudent.Count);
            var singlestudent = thesudent["Mvc"];
            Console.WriteLine(thesudent.Count(x => x.Value.Name.Contains("M")));
            Console.WriteLine(singlestudent.Name);
            foreach (var item in thesudent.Values)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Email);
            }
            foreach (var item in thesudent)
            {
                Console.WriteLine(item.Key+" "+item.Value.Id+" "+item.Value.Name);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
