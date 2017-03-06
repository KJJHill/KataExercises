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
        Given three int values, a b c, return the largest.
        intMax(1, 2, 3) → 3
        intMax(1, 3, 2) → 3
        intMax(3, 2, 1) → 3
        */
        public int IntMax(int a, int b, int c)
        {
            int result = 0;
            if (a>b && a>c)
            {
                result = a;
            }
            else if (b>a && b>c)
            {
                result = b;
            }
            else
            {
                result = c;
            }
            return result;
        }

    }
}
