﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of Strings, return a List containing the same 
         Strings in the same order 
         except for any words that contain exactly 4 characters.
         no4LetterWords( {"Train", "Boat", "Car"} )  ->  ["Train", "Car"]
         no4LetterWords( {"Red", "White", "Blue"} )  ->  ["Red", "White"]
         no4LetterWords( {"Jack", "Jill", "Jane", "John", "Jim"} )  ->  ["Jim"]
         */
        public List<string> No4LetterWords(string[] stringArray)
        {
            List<string> result = new List<string>();

            foreach (string myString in stringArray)
            {
                if (myString.Length != 4)
                {
                    result.Add(myString);
                }
            }
 
            return result;
        }

    }
}
