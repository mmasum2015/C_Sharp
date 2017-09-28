using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentDemo();
            InheritanceDemo();
            Console.ReadLine();
        }

        private static void InheritanceDemo()
        {
            Animal anAnimal = new Animal();
            anAnimal.Eat();
            Lion aLion = new Lion();
            aLion.Eat();
       /*     TellAnimalToEatTwice(aLion)*/;
        }

        //private static void TellAnimalToEatTwice(Lion aLion)
        //{
        //    aLion.Eat();
        //}

        private static void StudentDemo()
        {
            var mattias = new Student();
            mattias.Name = "Mattias Asplund";
            mattias.Email = "mattias@mattisasplund.se";
            mattias.TooTired += Mattias_TooTired;
            mattias.StudyHarder();
            mattias.StudyHarder();
            mattias.StudyHarder();
            Console.WriteLine($"Hello World to {mattias}");
            Console.ReadLine();
        }

        private static void Mattias_TooTired(object sender, EventArgs e)
        {
            Console.WriteLine("Student needs to rest");
            
        }
    }

    
    }

