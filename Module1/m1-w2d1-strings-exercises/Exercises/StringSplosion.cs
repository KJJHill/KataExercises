﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a non-empty string like "Code" return a string like "CCoCodCode".
         stringSplosion("Code") → "CCoCodCode"
         stringSplosion("abc") → "aababc"
         stringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {
            string results = "";
            for (int i = 0; i <str.Length; i++)
            {
                results = results + str.Substring(0, i + 1);
            }
            return results;
        }
    }
}
