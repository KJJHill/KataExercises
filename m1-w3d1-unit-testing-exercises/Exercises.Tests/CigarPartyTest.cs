using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void CigarTest()
        {
            CigarParty cG = new CigarParty();

            Assert.AreEqual(false, cG.HaveParty(30, false));
            Assert.AreEqual(true, cG.HaveParty(50, false));
            Assert.AreEqual(true, cG.HaveParty(40, false));
            Assert.AreEqual(true, cG.HaveParty(60, false));
            Assert.AreEqual(false, cG.HaveParty(65, false));
            Assert.AreEqual(true, cG.HaveParty(70, true));
            Assert.AreEqual(false, cG.HaveParty(30, true));

        }
    }
}
