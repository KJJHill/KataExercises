using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        /*
        Given an array of ints, return true if the array is length 1 or more, and the first element and
        the last element are equal.
        IsItTheSame([1, 2, 3]) → false
        IsItTheSame([1, 2, 3, 1]) → true
        IsItTheSame([1, 2, 1]) → true
        */
        [TestMethod]
        public void SameFirstLastTests()
        {
            SameFirstLast sameFirstLastTest = new SameFirstLast();
            Assert.AreEqual(false, sameFirstLastTest.IsItTheSame(new int[] { 1, 2, 3}));
            Assert.AreEqual(true, sameFirstLastTest.IsItTheSame(new int[] { 1, 2, 3, 1 }));
            Assert.AreEqual(true, sameFirstLastTest.IsItTheSame(new int[] { 1, 2, 1 }));
            Assert.AreEqual(false, sameFirstLastTest.IsItTheSame(new int[] { 1, 2 }));
            Assert.AreEqual(true, sameFirstLastTest.IsItTheSame(new int[] { 1, 1 }));

        }
    }
}
