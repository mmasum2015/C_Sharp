using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyerLib
{
    public class Multiplyer
    {
        public long Simple(long l1, long l2)
        {
            return l1 * l2;
        }

        public long While(long left, long right)
        {
            long total = 0;
            long loopvar = 0;
            while (loopvar< left)
            {
                total += right;
                loopvar++;
            }
            return total;
        }
    }
}
