using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {

        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         MakeArray([1, 2, 3]) → [3, 3, 3]
         MakeArray([11, 5, 9]) → [11, 11, 11]
         MakeArray([2, 11, 3]) → [3, 3, 3]
         */
        [TestMethod]
        public void MaxEndTest()
        {
            MaxEnd3 testMaxEnd3 = new MaxEnd3();

          
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, testMaxEnd3.MakeArray(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, testMaxEnd3.MakeArray(new int[] { 11, 5, 9 }));
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, testMaxEnd3.MakeArray(new int[] { 2, 11, 3 }));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, testMaxEnd3.MakeArray(new int[] { 2, 2, 2 }));


        }
    }
}
