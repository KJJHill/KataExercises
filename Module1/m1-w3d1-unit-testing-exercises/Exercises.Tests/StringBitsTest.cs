using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {

         /*
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         GetBits("Hello") → "Hlo"	
         GetBits("Hi") → "H"	
         GetBits("Heeololeo") → "Hello"	
         */
        [TestMethod]
        public void StringBitTest()
        {
            StringBits stringBitTest = new StringBits();

            Assert.AreEqual("Hlo", stringBitTest.GetBits("Hello"));
            Assert.AreEqual("H", stringBitTest.GetBits("Hi"));
            Assert.AreEqual("Hello", stringBitTest.GetBits("Heeololeo"));
            Assert.AreEqual("Hl", stringBitTest.GetBits("Helo"));

        }
    }
}
