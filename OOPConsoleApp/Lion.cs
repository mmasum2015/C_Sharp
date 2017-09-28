using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    internal class Lion : Animal
    {
        public Lion()
        {

        }
        
        internal override void Eat()
        {
            base.Eat();
            Console.WriteLine("Hunting Pray.");
        }
    }
}
