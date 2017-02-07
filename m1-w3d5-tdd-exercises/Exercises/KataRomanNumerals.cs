using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        Dictionary<int, string> conversion = new Dictionary<int, string>()
            {
                { 1, "I" }, {2, "II" }, {3, "III" }, {4, "IV" }, {5, "V" }, {6, "VI" }, {7, "VII" }, {8, "VIII" }, {9, "IX" },
                { 10, "X" }, {20, "XX" }, {30, "XXX" }, {40, "XL" }, {50, "L" }, {60, "LX" }, {70, "LXX" }, {80, "LXXX" }, {90, "XC" },
                {100, "C" }, {200, "CC" }, {300, "CCC" }, {400, "CD" }, {500, "D" }, {600,"DC" }, {700, "DCC" }, {800,"DCCC" }, {900,"CM" }, {1000, "M" }
            };
        public string GetRomanNumerals(int startingNumber)
        {


            string results = "";

            if (IsInRange(startingNumber, 1, 9))
            {
                results = conversion[startingNumber];
            }
            else if (IsInRange(startingNumber, 10, 99))
            {
                results += GetTwoDigitRomanNumeral(startingNumber);
            }
            else if (IsInRange(startingNumber, 100, 999))
            {
                results += GetThreeDigitRomanNumeral(startingNumber);
            }
            else if (IsInRange(startingNumber, 1000, 3000))
            {
                int i = 1;
                while (i <= (startingNumber / 1000))
                {
                    results += conversion[1000];
                }
                if (startingNumber % 1000 > 0)
                {
                    results += GetThreeDigitRomanNumeral(startingNumber % 1000);
                }
            }
            return results;
        }

        public bool IsInRange(int lookUp, int minimum, int maximum)
        {
            return (lookUp >= minimum && lookUp <= maximum) ? true : false;
        }

        public string GetTwoDigitRomanNumeral(int twoDigitRomanNumeral)
        {
            string results = conversion[(twoDigitRomanNumeral / 10) * 10];
            if (twoDigitRomanNumeral % 10 > 0)
            {
                results += conversion[twoDigitRomanNumeral % 10];
            }
            return results;
        }

        public string GetThreeDigitRomanNumeral(int threeDigitRomanNumeral)
        {
            string results = conversion[(threeDigitRomanNumeral / 100) * 100];
            if (threeDigitRomanNumeral % 100 > 0)
            {
                results += GetTwoDigitRomanNumeral(threeDigitRomanNumeral % 100);
            }
            return results;

        }

        public int GetHinduArabicNumerals(string startingRomanNumeral)
        {
            Dictionary<string, int> conversion = new Dictionary<string, int>()
            {
                {"I", 1 }, {"V", 2 }, {"X", 10 }, {"L", 50 }, {"C", 100 }, {"D", 500 }, {"M", 1000 }
            };
            int results = 0;

            int i = 1;
            while (i <= startingRomanNumeral.Length)
            {
                results += conversion[startingRomanNumeral.ElementAt(i-1).ToString()];
            }

            if ((startingRomanNumeral.Contains("IV")) || (startingRomanNumeral.Contains("IX")))
            {
                results -= 2;
            }
            if ((startingRomanNumeral.Contains("XL")) || (startingRomanNumeral.Contains("XC")))
            {
                results -= 20;
            }
            if ((startingRomanNumeral.Contains("CD")) || (startingRomanNumeral.Contains("CM")))
            {
                results -= 200;
            }

            return results;
        }
    }
}
