using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [Owner("Sukru")]
        public void Add_TwoInteger_ReturnSum()
        {
            int sum;
            CalculatorDemo.Calculator calculator = new CalculatorDemo.Calculator();

            sum = calculator.Add(3, 5);

            Assert.AreEqual(8, sum);
        }

        [TestMethod]
        public void Add_TwoIntegerAgain_ReturnSum()
        {
            int sum;
            CalculatorDemo.Calculator calculator = new CalculatorDemo.Calculator();

            sum = calculator.Add(3, 5);

            Assert.AreEqual(8, sum);
        }
    }
}
