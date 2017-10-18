using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartLib
{
    public class Accountibility
    {
        public Part commissioner;
        public Part responsible;
        public string roleName;

        public Accountibility(Part commissioner,
            Part responsible,
            string roleName)
        {
            this.commissioner = commissioner;
            this.responsible = responsible;
            this.roleName = roleName;
        }
        public override string ToString()
        {
            return $"{responsible.Name}, {roleName} på {commissioner.Name}";
        }
    }
}
