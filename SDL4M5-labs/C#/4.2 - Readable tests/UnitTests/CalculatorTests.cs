using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
        [TestCase("10,2", 8)]
        [TestCase("-10,2", -12)]
        public void Subtract_WithValidString_ShouldReturnExpectedValue(string input, int expectedResult)
        {
            int result = calculator.Subtract(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("10,2", 5)]
        [TestCase("-10,2", -5)]
        public void Divide_WithValidString_ShouldReturnExpectedValue(string input, int expectedResult)
        {
            int result = calculator.Divide(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("10,2", 20)]
        [TestCase("-10,2", -20)]
        public void Multiply_WithValidString_ShouldReturnExpectedValue(string input, int expectedResult)
        {
            int result = calculator.Multiply(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Divide_WithValidString_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide("10,0"));
        }
    }
}
