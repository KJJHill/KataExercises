using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {

        /*
         Given 2 strings, return their concatenation, except omit the first char of each. The strings will 
         be at least length 1.
         GetPartialString("Hello", "There") → "ellohere"
         GetPartialString("java", "code") → "avaode"	
         GetPartialString("shotl", "java") → "hotlava"	
        */
        [TestMethod]
        public void NonStartTests()
        {
            NonStart nonStartTest = new NonStart();
            Assert.AreEqual("ellohere", nonStartTest.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", nonStartTest.GetPartialString("java", "code"));
            Assert.AreEqual("hotlava", nonStartTest.GetPartialString("shotl", "java"));
            Assert.AreEqual("", nonStartTest.GetPartialString("s", "j"));
            Assert.AreEqual("a", nonStartTest.GetPartialString("s", "ja"));


        }
    }
}
