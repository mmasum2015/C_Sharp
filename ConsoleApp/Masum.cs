using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Masum
    {
        static void Main(string[] args)
        {
            var obj = new Book();
            obj.name = "Mvc";
            obj.id = 102;
            Console.WriteLine(obj.name+" "+ obj.id);
          
            Console.ReadKey();
        }
       
    }

    public class Book
    {
        internal string name;
        internal int id;

        


    } 
}
