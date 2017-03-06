using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPrimeFactors
    {
        public int[] Factorize(int startingNumber)
        {
            List<int> primeFactors = new List<int>();

            int counter = 2;
            int resolvedNumber = startingNumber;
            while (counter != resolvedNumber)
            {
                if(resolvedNumber % counter == 0)
                {
                    primeFactors.Add(counter);
                    resolvedNumber = resolvedNumber / counter;
                }
                else
                {
                    counter++;
                }

            }
            primeFactors.Add(counter);

            return primeFactors.ToArray();
        }
    }
}
