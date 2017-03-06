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
         Given an int n, return the absolute difference between n and 21, except return double the absolute 
         difference if n is over 21.
         diff21(19) → 2
         diff21(10) → 11
         diff21(21) → 0
         */
        public int Diff21(int n)
        {
            int result = 0;

            if (n < 0)
            {
                result = (0 - n) + 21;
            }
            else
            {

                if (n > 21)
                {
                    result = 2 * (n - 21);
                }
                else
                {
                    result = 21 - n;
                }
            }

            return result;
        }
    }
}
