using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCar = new Car("Rahams Bil");
            var anEngine = new Engine(350, 120000);
            var door1 = new Door(2000);
            var door2 = new Door(1500);
            var chassi = new Chassi(50000M);
            aCar.Parts.Add(anEngine);
            aCar.Parts.Add(door1);
            aCar.Parts.Add(door2);
            aCar.Parts.Add(chassi);
            decimal cost = aCar.Cost;
            Console.WriteLine($"{aCar} costs {cost}");
            Console.ReadLine();

        }
    }
}
