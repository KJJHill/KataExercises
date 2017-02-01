using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * GetCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * GetCount([]) → {}
         * GetCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */

        [TestMethod]
        public void WordCountTests()
        {
            WordCount wordCountTest = new WordCount();

            Dictionary<string, int> expected = new Dictionary<string, int>()
            { { "ba",  2 }, { "black", 1}, { "sheep", 1 } };
            CollectionAssert.AreEqual(expected, wordCountTest.GetCount(new string[] { "ba", "ba", "black", "sheep"}));

            expected = new Dictionary<string, int>()
            { { "a",  2 }, { "b", 2}, { "c", 1 } };
            CollectionAssert.AreEqual(expected, wordCountTest.GetCount(new string[] { "a", "b", "a", "c", "b" }));

            expected = new Dictionary<string, int>()
            { { "c",  1 }, { "b", 1}, { "a", 1 } };
            CollectionAssert.AreEqual(expected, wordCountTest.GetCount(new string[] { "c", "b", "a" }));

            expected = new Dictionary<string, int>()
            { };
            CollectionAssert.AreEqual(expected, wordCountTest.GetCount(new string[] {  }));


        }
    }
}
