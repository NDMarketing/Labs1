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
        [TestCase("10,abc", -9999, "Subtract")]
        [TestCase("10,abc", -9999, "Divide")]
        [TestCase("10,abc", -9999, "Multiply")]
        public void InvalidString_ShouldReturnMinus9999ForAllMethods(string input, int expectedResult, string method)
        {
            int result = 0;

            switch (method)
            {
                case "Subtract":
                    result = calculator.Subtract(input);
                    break;
                case "Divide":
                    result = calculator.Divide(input);
                    break;
                case "Multiply":
                    result = calculator.Multiply(input);
                    break;
            }

            Assert.AreEqual(expectedResult, result);
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
        [TestCase("10 2", 8, "Subtract")]
        [TestCase("10 2", 5, "Divide")]
        [TestCase("10 2", 20, "Multiply")]
        public void MissingComma_ShouldReturnExpectedValue(string input, int expectedResult, string method)
        {
            var methodMap = new Dictionary<string, Func<string, int>>
            {
                { "Subtract", calculator.Subtract },
                { "Divide", calculator.Divide },
                { "Multiply", calculator.Multiply }
            };

            int result = methodMap[method](input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void MissingDigit_shouldThrowIndexOutOfBoundsError()
        {
            Assert.Throws<IndexOutOfRangeException>(() => calculator.Divide("10"));
            Assert.Throws<IndexOutOfRangeException>(() => calculator.Multiply("10"));
            Assert.Throws<IndexOutOfRangeException>(() => calculator.Subtract("10"));
        }

        [Test]
        public void Divide_WithValidString_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide("10,0"));
        }
    }
}
