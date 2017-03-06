using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void LuckyTest()
        {
            Lucky13 luckytest = new Lucky13();

            Assert.AreEqual(true, luckytest.GetLucky(new int[] { 0, 2, 4 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 1, 2, 3 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 1, 2, 4 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 5, 1, 6 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 7, 8, 1 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 3, 2, 4 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 5, 3, 6 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 7, 8, 3 }));
            Assert.AreEqual(false, luckytest.GetLucky(new int[] { 1, 3, 3 }));
            Assert.AreEqual(true, luckytest.GetLucky(new int[] { 5, 6, 7 }));
            Assert.AreEqual(true, luckytest.GetLucky(new int[] { 8, 9, 4 }));

        }
    }
}
