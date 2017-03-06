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
         Given a string, return true if the first instance of "x" in the string is
         immediately followed by another "x".
         
         doubleX("axxbb") → true
         doubleX("axaxax") → false
         doubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            bool result = false;

            int findFirstX = str.IndexOf('x');

            if (findFirstX != str.Length-1 && findFirstX >= 0)
            {
                if (str[findFirstX] == 'x' && str[findFirstX + 1] == 'x')
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
