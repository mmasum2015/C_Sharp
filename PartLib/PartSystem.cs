using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartLib
{
    public class PartSystem
    {
        private List<Part> parts = new List<Part>();
        private List<Accountibility> accability
            = new List<Accountibility>();

        public int NumberOfParts
        {
            get
            {
                return parts.Count;            }
        }
        public int NumberOfAccountabilites
        {
            get
            {
                return accability.Count;
            }
        }

        public void AddAccountibility(Accountibility accountibility)
        {
            accability.Add(accountibility);
        }

        public void AddPart(Part part)
        {
             parts.Add(part);
        }

        public List<Accountibility> ResponsibilitesByParty(Part part)
        {
            return accability.Where(acc => acc.responsible.JuridicalId == part.JuridicalId).ToList();
        }
        
    }
}
