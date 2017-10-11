using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEAccountLib
{
    public class Account
    {
        public Account()
        {
            Children = new List<Account>();
        }
        public string Name { get; set; }
        public bool IsSummary { get; set; }
        public List<Account> Children { get; set; }
        public decimal Amount
        {
            get
            {
                if (!IsSummary)
                    return Children.Sum(child => child.Amount);
                return this.Amount;
            }
        }

    }
}
