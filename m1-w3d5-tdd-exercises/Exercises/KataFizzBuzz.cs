using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string GetFizzBuzz(int startingNumber)
        {
            string results = "";
            if (startingNumber > 0 && startingNumber < 100)
            {
                if (startingNumber%3 == 0)
                {
                    results += "Fizz";
                }
                if (startingNumber %5 == 0)
                {
                    results += "Buzz";
                }
                if ((startingNumber % 3 != 0) && (startingNumber % 5 != 0))
                {
                    results += startingNumber.ToString();
                }
            }
            return results;
        }

    }
}
