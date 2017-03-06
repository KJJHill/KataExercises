using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class PostageCalculatorTest
    {
        [TestMethod]

        public void PSFirstClassTest()
        {
            PostalService firstClassTest = new PostalService(2, 1, "FirstClass");
            Assert.AreEqual(2, firstClassTest.Distance);
            Assert.AreEqual(1, firstClassTest.Weight);
            Assert.AreEqual("FirstClass", firstClassTest.PostalClassType);
            Assert.AreEqual(0, firstClassTest.WeightCategory);
            Assert.AreEqual(0.07, firstClassTest.CalculateRate(2, 1));
            Assert.AreEqual(0.035, firstClassTest.Rate);
            Assert.AreEqual("Postal Service (1st Class)", firstClassTest.DeliveryNameAndType);


            firstClassTest = new PostalService(-2, -1, "FirstClass");
            Assert.AreEqual(0, firstClassTest.Distance);
            Assert.AreEqual(0, firstClassTest.Weight);
            Assert.AreEqual("FirstClass", firstClassTest.PostalClassType);

            firstClassTest = new PostalService(1, 1, "FirstClass");
            Assert.AreEqual(1, firstClassTest.Distance);
            Assert.AreEqual(1, firstClassTest.Weight);
            Assert.AreEqual("FirstClass", firstClassTest.PostalClassType);
            Assert.AreEqual(0, firstClassTest.WeightCategory);
            Assert.AreEqual(0.04, firstClassTest.CalculateRate(1, 1));

            //check to verify if different weights and classes were passsed in by the calculate rate method that it returns zero
            Assert.AreEqual(0.0, firstClassTest.CalculateRate(2, 10));
            Assert.AreEqual(0.0, firstClassTest.CalculateRate(12, 1));

            firstClassTest = new PostalService(341, 0, "FirstClass");
            Assert.AreEqual(0, firstClassTest.WeightCategory);
            Assert.AreEqual(11.94, firstClassTest.CalculateRate(341, 0));
            Assert.AreEqual(0.035, firstClassTest.Rate);
            firstClassTest = new PostalService(341, 2, "FirstClass");
            Assert.AreEqual(0, firstClassTest.WeightCategory);
            Assert.AreEqual(11.94, firstClassTest.CalculateRate(341, 2));
            Assert.AreEqual(0.035, firstClassTest.Rate);

            firstClassTest = new PostalService(341, 3, "FirstClass");
            Assert.AreEqual(1, firstClassTest.WeightCategory);
            Assert.AreEqual(13.64, firstClassTest.CalculateRate(341, 3));
            Assert.AreEqual(0.040, firstClassTest.Rate);
            firstClassTest = new PostalService(341, 8, "FirstClass");
            Assert.AreEqual(1, firstClassTest.WeightCategory);
            Assert.AreEqual(13.64, firstClassTest.CalculateRate(341, 8));
            Assert.AreEqual(0.040, firstClassTest.Rate);

            firstClassTest = new PostalService(341, 9, "FirstClass");
            Assert.AreEqual(2, firstClassTest.WeightCategory);
            Assert.AreEqual(16.03, firstClassTest.CalculateRate(341, 9));
            Assert.AreEqual(0.047, firstClassTest.Rate);
            firstClassTest = new PostalService(341, 15, "FirstClass");
            Assert.AreEqual(2, firstClassTest.WeightCategory);
            Assert.AreEqual(16.03, firstClassTest.CalculateRate(341, 15));
            Assert.AreEqual(0.047, firstClassTest.Rate);

            firstClassTest = new PostalService(341, 16, "FirstClass");
            Assert.AreEqual(3, firstClassTest.WeightCategory);
            Assert.AreEqual(66.50, firstClassTest.CalculateRate(341, 16));
            Assert.AreEqual(0.195, firstClassTest.Rate);
            firstClassTest = new PostalService(341, 48, "FirstClass");
            Assert.AreEqual(3, firstClassTest.WeightCategory);
            Assert.AreEqual(66.50, firstClassTest.CalculateRate(341, 48));
            Assert.AreEqual(0.195, firstClassTest.Rate);

            firstClassTest = new PostalService(341, 49, "FirstClass");
            Assert.AreEqual(4, firstClassTest.WeightCategory);
            Assert.AreEqual(153.45, firstClassTest.CalculateRate(341, 49));
            Assert.AreEqual(0.45, firstClassTest.Rate);
            firstClassTest = new PostalService(341, 128, "FirstClass");
            Assert.AreEqual(4, firstClassTest.WeightCategory);
            Assert.AreEqual(153.45, firstClassTest.CalculateRate(341, 128));
            Assert.AreEqual(0.45, firstClassTest.Rate);

            firstClassTest = new PostalService(341, 129, "FirstClass");
            Assert.AreEqual(5, firstClassTest.WeightCategory);
            Assert.AreEqual(170.5, firstClassTest.CalculateRate(341, 129));
            Assert.AreEqual(0.5, firstClassTest.Rate);
            firstClassTest = new PostalService(341, 229, "FirstClass");
            Assert.AreEqual(5, firstClassTest.WeightCategory);
            Assert.AreEqual(170.5, firstClassTest.CalculateRate(341, 229));
            Assert.AreEqual(0.5, firstClassTest.Rate);

            //public PostalService(int distance, double weight, string postalClassType)
            //public double CalculateRate(int distance, double weight)

            //               |1st Class| 2nd Class  | 3rd Class |
            //|categ |Ounces |Per Mile | Per Mile   | Per Mile |
            //|------| ------| --------| -----------| -----------|
            //|0 cat | 0 - 2 |   0.035 | 0.0035     | 0.0020 |
            //|1 cat | 3 - 8 |   0.040 | 0.0040     | 0.0022 |
            //|2 cat | 9 - 15|   0.047 | 0.0047     | 0.0024 |
            //|3 cat |16 - 48 |  0.195 | 0.0195     | 0.0150 |
            //|4 cat | 49-128 |  0.450 | 0.0450     | 0.0160 |
            //|5 cat | 129+   |  0.500 | 0.0500     | 0.0170
        }

        [TestMethod]
        public void PSSecondClassTest()
        {
            PostalService secondClassTest = new PostalService(2, 1, "SecondClass");
            Assert.AreEqual(2, secondClassTest.Distance);
            Assert.AreEqual(1, secondClassTest.Weight);
            Assert.AreEqual("SecondClass", secondClassTest.PostalClassType);
            Assert.AreEqual(0, secondClassTest.WeightCategory);
            Assert.AreEqual(0.01, secondClassTest.CalculateRate(2, 1));
            Assert.AreEqual(0.0035, secondClassTest.Rate);
            Assert.AreEqual("Postal Service (2nd Class)", secondClassTest.DeliveryNameAndType);

            secondClassTest = new PostalService(-2, -1, "SecondClass");
            Assert.AreEqual(0, secondClassTest.Distance);
            Assert.AreEqual(0, secondClassTest.Weight);
            Assert.AreEqual("SecondClass", secondClassTest.PostalClassType);

            secondClassTest = new PostalService(1, 1, "SecondClass");
            Assert.AreEqual(1, secondClassTest.Distance);
            Assert.AreEqual(1, secondClassTest.Weight);
            Assert.AreEqual("SecondClass", secondClassTest.PostalClassType);
            Assert.AreEqual(0, secondClassTest.WeightCategory);
            Assert.AreEqual(0.01, secondClassTest.CalculateRate(1, 1));

            //check to verify if different weights and classes were passsed in by the calculate rate method that it returns zero
            Assert.AreEqual(0.0, secondClassTest.CalculateRate(2, 10));
            Assert.AreEqual(0.0, secondClassTest.CalculateRate(12, 1));

            secondClassTest = new PostalService(341, 0, "SecondClass");
            Assert.AreEqual(0, secondClassTest.WeightCategory);
            Assert.AreEqual(1.19, secondClassTest.CalculateRate(341, 0));
            Assert.AreEqual(0.0035, secondClassTest.Rate);
            secondClassTest = new PostalService(341, 2, "SecondClass");
            Assert.AreEqual(0, secondClassTest.WeightCategory);
            Assert.AreEqual(1.19, secondClassTest.CalculateRate(341, 2));
            Assert.AreEqual(0.0035, secondClassTest.Rate);

            secondClassTest = new PostalService(341, 3, "SecondClass");
            Assert.AreEqual(1, secondClassTest.WeightCategory);
            Assert.AreEqual(1.36, secondClassTest.CalculateRate(341, 3));
            Assert.AreEqual(0.0040, secondClassTest.Rate);
            secondClassTest = new PostalService(341, 8, "SecondClass");
            Assert.AreEqual(1, secondClassTest.WeightCategory);
            Assert.AreEqual(1.36, secondClassTest.CalculateRate(341, 8));
            Assert.AreEqual(0.0040, secondClassTest.Rate);

            secondClassTest = new PostalService(341, 9, "SecondClass");
            Assert.AreEqual(2, secondClassTest.WeightCategory);
            Assert.AreEqual(1.60, secondClassTest.CalculateRate(341, 9));
            Assert.AreEqual(0.0047, secondClassTest.Rate);
            secondClassTest = new PostalService(341, 15, "SecondClass");
            Assert.AreEqual(2, secondClassTest.WeightCategory);
            Assert.AreEqual(1.60, secondClassTest.CalculateRate(341, 15));
            Assert.AreEqual(0.0047, secondClassTest.Rate);

            secondClassTest = new PostalService(341, 16, "SecondClass");
            Assert.AreEqual(3, secondClassTest.WeightCategory);
            Assert.AreEqual(6.65, secondClassTest.CalculateRate(341, 16));
            Assert.AreEqual(0.0195, secondClassTest.Rate);
            secondClassTest = new PostalService(341, 48, "SecondClass");
            Assert.AreEqual(3, secondClassTest.WeightCategory);
            Assert.AreEqual(6.65, secondClassTest.CalculateRate(341, 48));
            Assert.AreEqual(0.0195, secondClassTest.Rate);

            secondClassTest = new PostalService(341, 49, "SecondClass");
            Assert.AreEqual(4, secondClassTest.WeightCategory);
            Assert.AreEqual(15.35, secondClassTest.CalculateRate(341, 49));
            Assert.AreEqual(0.045, secondClassTest.Rate);
            secondClassTest = new PostalService(341, 128, "SecondClass");
            Assert.AreEqual(4, secondClassTest.WeightCategory);
            Assert.AreEqual(15.35, secondClassTest.CalculateRate(341, 128));
            Assert.AreEqual(0.045, secondClassTest.Rate);

            secondClassTest = new PostalService(341, 129, "SecondClass");
            Assert.AreEqual(5, secondClassTest.WeightCategory);
            Assert.AreEqual(17.05, secondClassTest.CalculateRate(341, 129));
            Assert.AreEqual(0.05, secondClassTest.Rate);
            secondClassTest = new PostalService(341, 229, "SecondClass");
            Assert.AreEqual(5, secondClassTest.WeightCategory);
            Assert.AreEqual(17.05, secondClassTest.CalculateRate(341, 229));
            Assert.AreEqual(0.05, secondClassTest.Rate);

            //public PostalService(int distance, double weight, string postalClassType)
            //public double CalculateRate(int distance, double weight)

            //               |1st Class| 2nd Class  | 3rd Class |
            //|categ |Ounces |Per Mile | Per Mile   | Per Mile |
            //|------| ------| --------| -----------| -----------|
            //|0 cat | 0 - 2 |   0.035 | 0.0035     | 0.0020 |
            //|1 cat | 3 - 8 |   0.040 | 0.0040     | 0.0022 |
            //|2 cat | 9 - 15|   0.047 | 0.0047     | 0.0024 |
            //|3 cat |16 - 48 |  0.195 | 0.0195     | 0.0150 |
            //|4 cat | 49-128 |  0.450 | 0.0450     | 0.0160 |
            //|5 cat | 129+   |  0.500 | 0.0500     | 0.0170
        }

        [TestMethod]
        public void PSThirdClassTest()
        {
            PostalService thirdClassTest = new PostalService(2, 1, "ThirdClass");
            Assert.AreEqual(2, thirdClassTest.Distance);
            Assert.AreEqual(1, thirdClassTest.Weight);
            Assert.AreEqual("ThirdClass", thirdClassTest.PostalClassType);
            Assert.AreEqual(0, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.01, thirdClassTest.CalculateRate(2, 1));
            Assert.AreEqual(0.0020, thirdClassTest.Rate);
            Assert.AreEqual("Postal Service (3rd Class)", thirdClassTest.DeliveryNameAndType);


            thirdClassTest = new PostalService(-2, -1, "ThirdClass");
            Assert.AreEqual(0, thirdClassTest.Distance);
            Assert.AreEqual(0, thirdClassTest.Weight);
            Assert.AreEqual("ThirdClass", thirdClassTest.PostalClassType);

            thirdClassTest = new PostalService(1, 1, "ThirdClass");
            Assert.AreEqual(1, thirdClassTest.Distance);
            Assert.AreEqual(1, thirdClassTest.Weight);
            Assert.AreEqual("ThirdClass", thirdClassTest.PostalClassType);
            Assert.AreEqual(0, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.01, thirdClassTest.CalculateRate(1, 1));

            //check to verify if different weights and classes were passsed in by the calculate rate method that it returns zero
            Assert.AreEqual(0.0, thirdClassTest.CalculateRate(2, 10));
            Assert.AreEqual(0.0, thirdClassTest.CalculateRate(12, 1));

            thirdClassTest = new PostalService(341, 0, "ThirdClass");
            Assert.AreEqual(0, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.68, thirdClassTest.CalculateRate(341, 0));
            Assert.AreEqual(0.0020, thirdClassTest.Rate);
            thirdClassTest = new PostalService(341, 2, "ThirdClass");
            Assert.AreEqual(0, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.68, thirdClassTest.CalculateRate(341, 2));
            Assert.AreEqual(0.0020, thirdClassTest.Rate);

            thirdClassTest = new PostalService(341, 3, "ThirdClass");
            Assert.AreEqual(1, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.75, thirdClassTest.CalculateRate(341, 3));
            Assert.AreEqual(0.0022, thirdClassTest.Rate);
            thirdClassTest = new PostalService(341, 8, "ThirdClass");
            Assert.AreEqual(1, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.75, thirdClassTest.CalculateRate(341, 8));
            Assert.AreEqual(0.0022, thirdClassTest.Rate);

            thirdClassTest = new PostalService(341, 9, "ThirdClass");
            Assert.AreEqual(2, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.82, thirdClassTest.CalculateRate(341, 9));
            Assert.AreEqual(0.0024, thirdClassTest.Rate);
            thirdClassTest = new PostalService(341, 15, "ThirdClass");
            Assert.AreEqual(2, thirdClassTest.WeightCategory);
            Assert.AreEqual(0.82, thirdClassTest.CalculateRate(341, 15));
            Assert.AreEqual(0.0024, thirdClassTest.Rate);

            thirdClassTest = new PostalService(341, 16, "ThirdClass");
            Assert.AreEqual(3, thirdClassTest.WeightCategory);
            Assert.AreEqual(5.12, thirdClassTest.CalculateRate(341, 16));
            Assert.AreEqual(0.0150, thirdClassTest.Rate);
            thirdClassTest = new PostalService(341, 48, "ThirdClass");
            Assert.AreEqual(3, thirdClassTest.WeightCategory);
            Assert.AreEqual(5.12, thirdClassTest.CalculateRate(341, 48));
            Assert.AreEqual(0.0150, thirdClassTest.Rate);

            thirdClassTest = new PostalService(341, 49, "ThirdClass");
            Assert.AreEqual(4, thirdClassTest.WeightCategory);
            Assert.AreEqual(5.46, thirdClassTest.CalculateRate(341, 49));
            Assert.AreEqual(0.0160, thirdClassTest.Rate);
            thirdClassTest = new PostalService(341, 128, "ThirdClass");
            Assert.AreEqual(4, thirdClassTest.WeightCategory);
            Assert.AreEqual(5.46, thirdClassTest.CalculateRate(341, 128));
            Assert.AreEqual(0.0160, thirdClassTest.Rate);

            thirdClassTest = new PostalService(341, 129, "ThirdClass");
            Assert.AreEqual(5, thirdClassTest.WeightCategory);
            Assert.AreEqual(5.80, thirdClassTest.CalculateRate(341, 129));
            Assert.AreEqual(0.0170, thirdClassTest.Rate);
            thirdClassTest = new PostalService(341, 229, "ThirdClass");
            Assert.AreEqual(5, thirdClassTest.WeightCategory);
            Assert.AreEqual(5.80, thirdClassTest.CalculateRate(341, 229));
            Assert.AreEqual(0.0170, thirdClassTest.Rate);

            //public PostalService(int distance, double weight, string postalClassType)
            //public double CalculateRate(int distance, double weight)

            //               |1st Class| 2nd Class  | 3rd Class |
            //|categ |Ounces |Per Mile | Per Mile   | Per Mile |
            //|------| ------| --------| -----------| -----------|
            //|0 cat | 0 - 2 |   0.035 | 0.0035     | 0.0020 |
            //|1 cat | 3 - 8 |   0.040 | 0.0040     | 0.0022 |
            //|2 cat | 9 - 15|   0.047 | 0.0047     | 0.0024 |
            //|3 cat |16 - 48 |  0.195 | 0.0195     | 0.0150 |
            //|4 cat | 49-128 |  0.450 | 0.0450     | 0.0160 |
            //|5 cat | 129+   |  0.500 | 0.0500     | 0.0170
        }

        [TestMethod]
        public void FedExTest()
        {
            Fedex fedExTest = new Fedex(-3, -5);
            Assert.AreEqual(0, fedExTest.Distance);
            Assert.AreEqual(0, fedExTest.Weight);

            fedExTest = new Fedex(3, 5);
            Assert.AreEqual(3, fedExTest.Distance);
            Assert.AreEqual(5, fedExTest.Weight);
            Assert.AreEqual(20, fedExTest.Rate);
            Assert.AreEqual(0, fedExTest.CalculateRate(4, 5));
            Assert.AreEqual(0, fedExTest.CalculateRate(3, 6));
            Assert.AreEqual(20, fedExTest.CalculateRate(3, 5));
            Assert.AreEqual("FedEx", fedExTest.DeliveryNameAndType);

            fedExTest = new Fedex(500, 5);
            Assert.AreEqual(500, fedExTest.Distance);
            Assert.AreEqual(5, fedExTest.Weight);
            Assert.AreEqual(20, fedExTest.CalculateRate(500, 5));
            Assert.AreEqual(20, fedExTest.Rate);

            fedExTest = new Fedex(501, 5);
            Assert.AreEqual(501, fedExTest.Distance);
            Assert.AreEqual(5, fedExTest.Weight);
            Assert.AreEqual(25, fedExTest.CalculateRate(501, 5));
            Assert.AreEqual(25, fedExTest.Rate);

            fedExTest = new Fedex(500, 48);
            Assert.AreEqual(500, fedExTest.Distance);
            Assert.AreEqual(48, fedExTest.Weight);
            Assert.AreEqual(20, fedExTest.CalculateRate(500, 48));
            Assert.AreEqual(20, fedExTest.Rate);

            fedExTest = new Fedex(500, 49);
            Assert.AreEqual(500, fedExTest.Distance);
            Assert.AreEqual(49, fedExTest.Weight);
            Assert.AreEqual(23, fedExTest.CalculateRate(500, 49));
            Assert.AreEqual(23, fedExTest.Rate);

            fedExTest = new Fedex(501, 55);
            Assert.AreEqual(501, fedExTest.Distance);
            Assert.AreEqual(55, fedExTest.Weight);
            Assert.AreEqual(28, fedExTest.CalculateRate(501, 55));
            Assert.AreEqual(28, fedExTest.Rate);
        }

        [TestMethod]
        public void SPUTest()
        {
            SPU negativeValueTest = new SPU(-1, -2, "");
            Assert.AreEqual(0, negativeValueTest.Distance);
            Assert.AreEqual(0, negativeValueTest.Weight);
            Assert.AreEqual(null, negativeValueTest.SPUType);
            negativeValueTest.CalculateRate(-1, -2);
            Assert.AreEqual(0, negativeValueTest.Rate);

            //check to verify if different weights and classes were passsed in by the calculate rate method that it returns zero
            negativeValueTest = new SPU(1, 2, "");
            Assert.AreEqual(0, negativeValueTest.CalculateRate(1, 10));
            Assert.AreEqual(0, negativeValueTest.CalculateRate(12, 2));

            SPU fourDayTest = new SPU(1, 1, "4-day");
            Assert.AreEqual(1, fourDayTest.Distance);
            Assert.AreEqual(1, fourDayTest.Weight);
            Assert.AreEqual("4-day", fourDayTest.SPUType);
            fourDayTest.CalculateRate(1, 1);
            Assert.AreEqual(0.01, fourDayTest.Rate);
            Assert.AreEqual("SPU (4-day ground)", fourDayTest.DeliveryNameAndType);

            fourDayTest = new SPU(96, 96, "4-day");
            fourDayTest.CalculateRate(96, 96);
            Assert.AreEqual(46.08, fourDayTest.Rate);

            SPU twoDayTest = new SPU(1, 1, "2-day");
            Assert.AreEqual(1, twoDayTest.Distance);
            Assert.AreEqual(1, twoDayTest.Weight);
            Assert.AreEqual("2-day", twoDayTest.SPUType);
            twoDayTest.CalculateRate(1, 1);
            Assert.AreEqual(0.05, twoDayTest.Rate);
            Assert.AreEqual("SPU (2-day business)", twoDayTest.DeliveryNameAndType);

            twoDayTest = new SPU(255, 75, "2-day");
            twoDayTest.CalculateRate(255, 75);
            Assert.AreEqual(956.25, twoDayTest.Rate);

            SPU nextDayTest = new SPU(1, 1, "Next-day");
            Assert.AreEqual(1, nextDayTest.Distance);
            Assert.AreEqual(1, nextDayTest.Weight);
            Assert.AreEqual("Next-day", nextDayTest.SPUType);
            nextDayTest.CalculateRate(1, 1);
            Assert.AreEqual(0.08, nextDayTest.Rate);
            Assert.AreEqual("SPU (next-day)", nextDayTest.DeliveryNameAndType);

            nextDayTest = new SPU(25, 75, "Next-day");
            nextDayTest.CalculateRate(25, 75);
            Assert.AreEqual(140.63, nextDayTest.Rate);
        }
    }
}
