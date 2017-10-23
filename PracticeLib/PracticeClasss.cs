using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLib
{
    public class PracticeClasss
    {
        private string Name;
        private string BirthDate;
        private string Phone;
        
        public string Greeting
        {
            get
            {
                return $"{this.Name}; was born {this.BirthDate}; and his phone no {this.Phone}";
            }
        }

        public void EnterDetails(string birthDate, string name, string phone)
        {
            this.Name = name;
           this.BirthDate = birthDate;
            this.Phone = phone;
        }
    }
}
