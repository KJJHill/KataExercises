using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int values, return true if either of them is in the range 10..20 inclusive.
         in1020(12, 99) → true
         in1020(21, 12) → true
         in1020(8, 99) → false
         */
        public bool In1020(int a, int b)
        {
            bool result = false;
            if ((10 <= a) && (a <= 20))
            {
                result = true;
            }
            else if ((10 <= b) && (b <= 20))
            {
                result = true;
            }
            return result;
        }

    }
}
