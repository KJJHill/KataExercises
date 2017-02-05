using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class TollBoothCalculatorTest
    {
        [TestMethod]
        public void CarTest()
        {
            Car carVehichle = new Car(false);
            Assert.AreEqual(false, carVehichle.HasTrailer);
            Assert.AreEqual("Car without Trailer", carVehichle.TypeOfVehichle);
            Assert.AreEqual(0, carVehichle.CalculateToll(-23));
            Assert.AreEqual(0, carVehichle.Distance);
            Assert.AreEqual(0, carVehichle.Toll);
            Assert.AreEqual(10, carVehichle.CalculateToll(500));
            Assert.AreEqual(500, carVehichle.Distance);
            Assert.AreEqual(10, carVehichle.Toll);
            Assert.AreEqual(9.98, carVehichle.CalculateToll(499));
            Assert.AreEqual(0, carVehichle.CalculateToll(0));
            Assert.AreEqual(0.04, carVehichle.CalculateToll(2));

            carVehichle = new Car(true);
            Assert.AreEqual(true, carVehichle.HasTrailer);
            Assert.AreEqual("Car with Trailer", carVehichle.TypeOfVehichle);
            Assert.AreEqual(0, carVehichle.CalculateToll(0));
            Assert.AreEqual(11, carVehichle.CalculateToll(500));
            Assert.AreEqual(500, carVehichle.Distance);
            Assert.AreEqual(11, carVehichle.Toll);
            Assert.AreEqual(10.98, carVehichle.CalculateToll(499));
            Assert.AreEqual(1.04, carVehichle.CalculateToll(2));

        }
        [TestMethod]
        public void TruckTest()
        {
            Truck truckTest = new Truck(4);
            truckTest.CalculateToll(4);
            Assert.AreEqual(4, truckTest.NumberOfAxles);
            Assert.AreEqual(4, truckTest.Distance);
            Assert.AreEqual(.16, truckTest.Toll);
            Assert.AreEqual(0.04, truckTest.RatePerMile);
            Assert.AreEqual("Truck with 4 Axles", truckTest.TypeOfVehichle);

            truckTest.CalculateToll(256);
            Assert.AreEqual(10.24, truckTest.Toll);

            truckTest = new Truck(-3);
            truckTest.CalculateToll(-3);
            Assert.AreEqual(0.0, truckTest.Distance);
            Assert.AreEqual(0, truckTest.Toll);
            Assert.AreEqual(0, truckTest.NumberOfAxles);

            truckTest = new Truck(0);
            truckTest.CalculateToll(0);
            Assert.AreEqual(0.0, truckTest.Distance);
            Assert.AreEqual(0, truckTest.Toll);
            Assert.AreEqual(0, truckTest.NumberOfAxles);

            truckTest = new Truck(6);
            truckTest.CalculateToll(9);
            Assert.AreEqual(6, truckTest.NumberOfAxles);
            Assert.AreEqual(9, truckTest.Distance);
            Assert.AreEqual(.41, truckTest.Toll);
            Assert.AreEqual(0.045, truckTest.RatePerMile);
            Assert.AreEqual("Truck with 6 Axles", truckTest.TypeOfVehichle);

            truckTest.CalculateToll(909);
            Assert.AreEqual(909, truckTest.Distance);
            Assert.AreEqual(40.91, truckTest.Toll);

            truckTest = new Truck(8);
            truckTest.CalculateToll(9);
            Assert.AreEqual(8, truckTest.NumberOfAxles);
            Assert.AreEqual(9, truckTest.Distance);
            Assert.AreEqual(.43, truckTest.Toll);
            Assert.AreEqual(0.048, truckTest.RatePerMile);
            Assert.AreEqual("Truck with 8 Axles", truckTest.TypeOfVehichle);
            
            truckTest.CalculateToll(911);
            Assert.AreEqual(911, truckTest.Distance);
            Assert.AreEqual(43.73, truckTest.Toll);
        }

        [TestMethod]
        public void TankTest()
        {
            Tank tankVehichle = new Tank();
            Assert.AreEqual(0, tankVehichle.CalculateToll(-23));
            Assert.AreEqual(0, tankVehichle.Distance);
            Assert.AreEqual(0, tankVehichle.Toll);
            Assert.AreEqual(0, tankVehichle.CalculateToll(500));
            Assert.AreEqual(500, tankVehichle.Distance);
            Assert.AreEqual(0, tankVehichle.Toll);
            Assert.AreEqual("Tank", tankVehichle.TypeOfVehichle);

        }
    }
}
