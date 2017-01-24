using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with 
         "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0. Note: use .equals()
         to compare 2 strings.
         hasBad("badxx") → true
         hasBad("xbadxx") → true
         hasBad("xxbadxx") → false
         */
        public bool HasBad(string str)
        {
            bool result = false;

            if (str.Length > 2)
            {
                if (str.Length == 3)
                {
                    result = (str[0] == 'b' && str[1] == 'a' && str[2] == 'd') ? true : false;
                }
                else
                {
                    result = ((str[0] == 'b' && str[1] == 'a' && str[2] == 'd')
                        || (str[1] == 'b' && str[2] == 'a' && str[3] == 'd')) ? true : false;
                }
            }
            return result;
        }
    }
}
