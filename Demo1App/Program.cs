using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1App
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalage = 0;
            for (int age = 0; age < 100 ; age++)
            {
                totalage += age;
                Console.WriteLine("We can see upto the 100 years " + age);
                Console.WriteLine(new string ('-' , 50));
            }
            Console.WriteLine("Sum for total age " + totalage);
            Console.ReadKey();
        }
    }
}
