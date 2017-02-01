using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {

        /* If the name of the animal is not found, null, or empty, return "unknown". 
        *
         * The animal name should be case insensitive so "elephant", "Elephant", and 
        * "ELEPHANT" should all return "herd". 
        * Rhino -> Crash
        * Giraffe -> Tower
        * Elephant -> Herd
        * Lion -> Pride
        * Crow -> Murder
        * Pigeon -> Kit
        * Flamingo -> Pat
        * Deer -> Herd
        * Dog -> Pack
        * Crocodile -> Float
        *
        * GetHerd("giraffe") → "Tower"
        * GetHerd("") -> "unknown"         
        * GetHerd("walrus") -> "unknown"
        * GetHerd("Rhino") -> "Crash"
        * GetHerd("rhino") -> "Crash"
        * GetHerd("elephants") -> "unknown"
   */
        [TestMethod]
        public void AnimalNameTest()
        {
            AnimalGroupName animal = new AnimalGroupName();

            Assert.AreEqual("Crash", animal.GetHerd("Rhino"));
            Assert.AreEqual("Crash", animal.GetHerd("rhino"));
            Assert.AreEqual("Crash", animal.GetHerd("RHINO"));
            Assert.AreEqual("Crash", animal.GetHerd("rhiNo"));
            Assert.AreEqual("unknown", animal.GetHerd("Rhinos"));
            Assert.AreEqual("unknown", animal.GetHerd(""));
           //Assert.AreEqual("unknown", animal.GetHerd(null));
            Assert.AreEqual("Herd", animal.GetHerd("elephant"));
            Assert.AreEqual("Pride", animal.GetHerd("lion"));
            Assert.AreEqual("Murder", animal.GetHerd("crow"));
            Assert.AreEqual("Kit", animal.GetHerd("Pigeon"));
            Assert.AreEqual("Pat", animal.GetHerd("Flamingo"));
            Assert.AreEqual("Herd", animal.GetHerd("deer"));
            Assert.AreEqual("Pack", animal.GetHerd("Dog"));
            Assert.AreEqual("Float", animal.GetHerd("Crocodile"));
            Assert.AreEqual("Tower", animal.GetHerd("giraffe"));

        }
    }
}
