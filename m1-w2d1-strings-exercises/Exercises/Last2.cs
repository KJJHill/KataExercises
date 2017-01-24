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

            This code is not written very succintly, but it works.  
            in another context I would take the time to make this cleaner.

         Given a string, return the count of the number of times that a substring 
         length 2 appears in the string and 
         also as the last 2 chars of the string, so "hixxxhi" 
         yields 1 (we won't count the end substring).
         
         last2("hixxhi") → 1
         last2("xaxxaxaxx") → 1
         last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            int result = 0;
                //if length is <= 2 or if there is no match found return null
            if (str.Length <= 2) 
            {
                return result;
            }

            string subString = str.Substring(str.Length - 2, 2);
            int i = str.IndexOf(subString);

            if (i < 0)
            {
                return result;
            }

            for (; i < str.Length - 2; i++)

            {
                if ((str.IndexOf(subString, i) >= 0)

                && (str.IndexOf(subString, i) != str.LastIndexOf(subString)))

                {
                    i = str.IndexOf(subString, i + 1) - 1;
                    result++;
                }
            }
            
            return result;
        }
    }
}
