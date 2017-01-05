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
            WeightCalculator a = new WeightCalculator(100);

            double result = a.calcWeight(a.getWeight());
            double expectedResult = 40;

            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void displayWeightTest()
        {
            WeightCalculator a = new WeightCalculator(40);

            String result = a.weightToDisplay(22.5);
            String expectedResult = "20 plates : 2 ";

            Assert.AreEqual(expectedResult, result);

        }
    }
}
