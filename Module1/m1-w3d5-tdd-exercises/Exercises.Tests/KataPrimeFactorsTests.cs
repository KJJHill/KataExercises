using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPrimeFactorsTests
    {
        //        2 -> returns[2]
        //3 -> returns[3]
        //4 -> returns[2, 2]
        //6 -> returns[2, 3]
        //7 -> returns[7]
        //8 -> returns[2, 2, 2]
        //9 -> returns[3, 3]
        //10 -> returns[2, 5]
        [TestMethod]
        public void KataGetPRimeFactorsTest()
        {
            KataPrimeFactors kataTest = new KataPrimeFactors();

            CollectionAssert.AreEqual(new int[] { 2}, kataTest.Factorize(2));
            CollectionAssert.AreEqual(new int[] { 3 }, kataTest.Factorize(3));
            CollectionAssert.AreEqual(new int[] { 2, 2 }, kataTest.Factorize(4));
            CollectionAssert.AreEqual(new int[] { 2, 3 }, kataTest.Factorize(6));
            CollectionAssert.AreEqual(new int[] { 7 }, kataTest.Factorize(7));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, kataTest.Factorize(8));
            CollectionAssert.AreEqual(new int[] { 3, 3 }, kataTest.Factorize(9));
            CollectionAssert.AreEqual(new int[] { 2, 5 }, kataTest.Factorize(10));

        }


    }
}
