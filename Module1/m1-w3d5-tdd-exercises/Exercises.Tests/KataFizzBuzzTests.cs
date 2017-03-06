using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        public void KataFizzBuzz()
        {
            KataFizzBuzz fizzBuzzTest = new KataFizzBuzz();
            Assert.AreEqual("", fizzBuzzTest.GetFizzBuzz(0));
            Assert.AreEqual("", fizzBuzzTest.GetFizzBuzz(101));
            Assert.AreEqual("Fizz", fizzBuzzTest.GetFizzBuzz(3));
            Assert.AreEqual("Buzz", fizzBuzzTest.GetFizzBuzz(5));
            Assert.AreEqual("4", fizzBuzzTest.GetFizzBuzz(4));
            Assert.AreEqual("FizzBuzz", fizzBuzzTest.GetFizzBuzz(30));

        }
    }
}
