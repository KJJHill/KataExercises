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
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or 
         whatever is there if the string is less than length 3. Return n copies of the front;
         frontTimes("Chocolate", 2) → "ChoCho"
         frontTimes("Chocolate", 3) → "ChoChoCho"
         frontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
            string results = "";
            string frontString = "";

            if (str.Length > 0)
            {
                frontString = (str.Length > 2) ? str.Substring(0, 3) : (str.Length == 2) ? str.Substring(0, 2) : str.Substring(0, 1);

                for (int i = 0; i < n; i++)
                {
                    results = results + frontString;
                }
            }

            return results;
        }

    }
}
