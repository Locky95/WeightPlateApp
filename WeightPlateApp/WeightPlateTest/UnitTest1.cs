using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeightPlateApp;


namespace WeightPlateTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calcWeightTest()
        {
            WeightCalculator a = new WeightCalculator();

            double result = a.calcWeight(100);
            double expectedResult = 40;

            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void displayWeightTest()
        {
            WeightCalculator a = new WeightCalculator();

            String result = a.calcWeight(10);
            String expectedResult = "20 plates : 2\n";

            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void displayRecursiveWeightTest()
        {
            WeightCalculator a = new WeightCalculator();

            String result = a.calcPlatesNeeded(140);
            String expectedResult = "20 plates : 2 ";

            Assert.AreEqual(expectedResult, result);

        }
    }
}
