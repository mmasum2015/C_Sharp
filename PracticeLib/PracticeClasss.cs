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
        private string Age;
        public string Greeting
        {
            get
            {
                return $"{this.Name}; was born {this.BirthDate}; he is {this.Age} years old; and his phone no {this.Phone}";
            }
        }

        public void EnterDetails(string birthDate, string name,string age, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.BirthDate = birthDate;
            this.Phone = phone;
        }
    }
}
