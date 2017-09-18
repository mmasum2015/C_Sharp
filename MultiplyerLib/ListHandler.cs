using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyerLib
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {
            List.Add("Masum");
            List.Add("Mattias");
            List.Add("Jahurul");
            List.Add("Razib");
            List.Add("Alex");
            //List.Add("Mustafa");
            //List.Add("AlexRed");
        }

        public void RemoveThirdString()
        {
            List.Remove("Jahurul");
        }

        public void Sort()
        {
            List.Sort();
        }

    }
}
