using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        [TestMethod]
        public void GetRomanNumeralsTest()
        {
            KataRomanNumerals romanNumeralsTest = new KataRomanNumerals();

            Assert.AreEqual("I", romanNumeralsTest.GetRomanNumerals(1));
            Assert.AreEqual("II", romanNumeralsTest.GetRomanNumerals(2));
            Assert.AreEqual("III", romanNumeralsTest.GetRomanNumerals(3));
            Assert.AreEqual("IV", romanNumeralsTest.GetRomanNumerals(4));
            Assert.AreEqual("V", romanNumeralsTest.GetRomanNumerals(5));
            Assert.AreEqual("VI", romanNumeralsTest.GetRomanNumerals(6));
            Assert.AreEqual("VII", romanNumeralsTest.GetRomanNumerals(7));
            Assert.AreEqual("VIII", romanNumeralsTest.GetRomanNumerals(8));
            Assert.AreEqual("IX", romanNumeralsTest.GetRomanNumerals(9));

            Assert.AreEqual("X", romanNumeralsTest.GetRomanNumerals(10));
            Assert.AreEqual("XX", romanNumeralsTest.GetRomanNumerals(20));
            Assert.AreEqual("XXX", romanNumeralsTest.GetRomanNumerals(30));
            Assert.AreEqual("XL", romanNumeralsTest.GetRomanNumerals(40));
            Assert.AreEqual("L", romanNumeralsTest.GetRomanNumerals(50));
            Assert.AreEqual("LX", romanNumeralsTest.GetRomanNumerals(60));
            Assert.AreEqual("LXX", romanNumeralsTest.GetRomanNumerals(70));
            Assert.AreEqual("LXXX", romanNumeralsTest.GetRomanNumerals(80));
            Assert.AreEqual("XC", romanNumeralsTest.GetRomanNumerals(90));

            Assert.AreEqual("C", romanNumeralsTest.GetRomanNumerals(100));
            Assert.AreEqual("CC", romanNumeralsTest.GetRomanNumerals(200));
            Assert.AreEqual("CCC", romanNumeralsTest.GetRomanNumerals(300));
            Assert.AreEqual("CD", romanNumeralsTest.GetRomanNumerals(400));
            Assert.AreEqual("D", romanNumeralsTest.GetRomanNumerals(500));
            Assert.AreEqual("DC", romanNumeralsTest.GetRomanNumerals(600));
            Assert.AreEqual("DCC", romanNumeralsTest.GetRomanNumerals(700));
            Assert.AreEqual("DCCC", romanNumeralsTest.GetRomanNumerals(800));
            Assert.AreEqual("CM", romanNumeralsTest.GetRomanNumerals(900));
            Assert.AreEqual("M", romanNumeralsTest.GetRomanNumerals(1000));

            Assert.AreEqual("XXIII", romanNumeralsTest.GetRomanNumerals(23));
            Assert.AreEqual("CMIX", romanNumeralsTest.GetRomanNumerals(99));
            Assert.AreEqual("CCIII", romanNumeralsTest.GetRomanNumerals(203));
            Assert.AreEqual("CCXXIII", romanNumeralsTest.GetRomanNumerals(223));

            Assert.AreEqual("MIX", romanNumeralsTest.GetRomanNumerals(1009));
            Assert.AreEqual("MXIII", romanNumeralsTest.GetRomanNumerals(1013));
            Assert.AreEqual("MC", romanNumeralsTest.GetRomanNumerals(1100));
            Assert.AreEqual("MCIII", romanNumeralsTest.GetRomanNumerals(1103));
            Assert.AreEqual("MCXXIV", romanNumeralsTest.GetRomanNumerals(1124));

            Assert.AreEqual("MCMXC", romanNumeralsTest.GetRomanNumerals(1990));
            Assert.AreEqual("MMVIII", romanNumeralsTest.GetRomanNumerals(2008));
        }

        [TestMethod]
        public void GetHinduArabicNumbersTest()
        {
            KataRomanNumerals romanNumeralsTest = new KataRomanNumerals();


            Assert.AreEqual(1, romanNumeralsTest.GetHinduArabicNumerals("I"));
            Assert.AreEqual(5, romanNumeralsTest.GetHinduArabicNumerals("V"));
            Assert.AreEqual(10, romanNumeralsTest.GetHinduArabicNumerals("X"));
            Assert.AreEqual(50, romanNumeralsTest.GetHinduArabicNumerals("L"));
            Assert.AreEqual(100, romanNumeralsTest.GetHinduArabicNumerals("C"));
            Assert.AreEqual(500, romanNumeralsTest.GetHinduArabicNumerals("D"));
            Assert.AreEqual(1000, romanNumeralsTest.GetHinduArabicNumerals("M"));

            Assert.AreEqual(2, romanNumeralsTest.GetHinduArabicNumerals("II"));
            Assert.AreEqual(3, romanNumeralsTest.GetHinduArabicNumerals("III"));
            Assert.AreEqual(4, romanNumeralsTest.GetHinduArabicNumerals("IV"));
            Assert.AreEqual(6, romanNumeralsTest.GetHinduArabicNumerals("VI"));
            Assert.AreEqual(7, romanNumeralsTest.GetHinduArabicNumerals("VII"));
            Assert.AreEqual(8, romanNumeralsTest.GetHinduArabicNumerals("VIII"));
            Assert.AreEqual(9, romanNumeralsTest.GetHinduArabicNumerals("IX"));

            Assert.AreEqual(20, romanNumeralsTest.GetHinduArabicNumerals("XX"));
            Assert.AreEqual(30, romanNumeralsTest.GetHinduArabicNumerals("XXX"));
            Assert.AreEqual(40, romanNumeralsTest.GetHinduArabicNumerals("XL"));
            Assert.AreEqual(60, romanNumeralsTest.GetHinduArabicNumerals("LX"));
            Assert.AreEqual(70, romanNumeralsTest.GetHinduArabicNumerals("LXX"));
            Assert.AreEqual(80, romanNumeralsTest.GetHinduArabicNumerals("LXXX"));
            Assert.AreEqual(90, romanNumeralsTest.GetHinduArabicNumerals("XC"));

            Assert.AreEqual(23, romanNumeralsTest.GetHinduArabicNumerals("XXIII"));
            Assert.AreEqual(99, romanNumeralsTest.GetHinduArabicNumerals("CMIX"));

            Assert.AreEqual(200, romanNumeralsTest.GetHinduArabicNumerals("CC"));
            Assert.AreEqual(300, romanNumeralsTest.GetHinduArabicNumerals("CCC"));
            Assert.AreEqual(400, romanNumeralsTest.GetHinduArabicNumerals("CD"));
            Assert.AreEqual(600, romanNumeralsTest.GetHinduArabicNumerals("DC"));
            Assert.AreEqual(700, romanNumeralsTest.GetHinduArabicNumerals("DCC"));
            Assert.AreEqual(800, romanNumeralsTest.GetHinduArabicNumerals("DCCC"));
            Assert.AreEqual(900, romanNumeralsTest.GetHinduArabicNumerals("CM"));

            Assert.AreEqual(203, romanNumeralsTest.GetHinduArabicNumerals("CCIII"));
            Assert.AreEqual(223, romanNumeralsTest.GetHinduArabicNumerals("CCXXIII"));

            Assert.AreEqual(1009, romanNumeralsTest.GetHinduArabicNumerals("MIX"));
            Assert.AreEqual(1013, romanNumeralsTest.GetHinduArabicNumerals("MXIII"));
            Assert.AreEqual(1100, romanNumeralsTest.GetHinduArabicNumerals("MC"));
            Assert.AreEqual(1103, romanNumeralsTest.GetHinduArabicNumerals("MCIII"));
            Assert.AreEqual(1124, romanNumeralsTest.GetHinduArabicNumerals("MCXXIV"));

            Assert.AreEqual(1990, romanNumeralsTest.GetHinduArabicNumerals("MCMXC"));
            Assert.AreEqual(2008, romanNumeralsTest.GetHinduArabicNumerals("MMVIII"));
        }

    }
}
