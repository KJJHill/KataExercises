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
        Given a string, return a version where all the "x" have been removed. 
        Except an "x" at the very start or end 
        should not be removed.
        stringX("xxHxix") → "xHix"
        stringX("abxxxcd") → "abcd"
        stringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {

            string result = str;
            if (result.Length > 0)
            {
                int xIndex = result.IndexOf("x", 1);

                //do while the x is not in the 0 index and not equal to the last value
                while (xIndex >= 1 && xIndex != result.Length - 1)
                {
                    result = result.Remove(result.IndexOf("x", 1), 1);
                    xIndex = result.IndexOf("x", 1);
                }
            }
            return result;
        }
    }
}
