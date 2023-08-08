using NUnit.Framework;
using QACalculator;
using System;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase("10,5", 5)]    // 10 - 5 = 5
        [TestCase("-5,3", -8)]   // -5 - 3 = -8
        [TestCase("0,0", 0)]     // 0 - 0 = 0
        [TestCase("abc,5", -9999)] // Should Return -9999
        [TestCase("10,xyz", -9999)] // Should Return -9999
        [TestCase("5", -9999)]      // Should Return -9999 BREAKS TEST
        public void Subtract_Input_ReturnsCorrectResultOrNegative9999(string input, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var result = calculator.Subtract(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("10,5", 50)]    // 10 x 5 = 50
        [TestCase("-5,3", -15)]   // -5 x 3 = -5
        [TestCase("0,0", 0)]     // 0 x 0 = 0
        [TestCase("abc,5", -9999)] // Should Return -9999
        [TestCase("10,xyz", -9999)] // Should Return -9999
        [TestCase("5", -9999)]      // Should Return -9999 BREAKS TEST
        public void Multiply_Input_ReturnsCorrectResultOrNegative9999(string input, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var result = calculator.Multiply(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("10,5", 2)]    // 10 / 5 = 2
        //[TestCase("-5,3", -8)]   // -5 / 3 = ???
        [TestCase("abc,5", -9999)] // Should Return -9999
        [TestCase("10,xyz", -9999)] // Should Return -9999
        //[TestCase("5", -9999)]      // Should Return -9999 BREAKS TEST
        public void Divide_Input_ReturnsCorrectResultOrNegative9999(string input, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var result = calculator.Divide(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void DivideByZero_ValidString_ShouldReturnException()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Assert Act
            Assert.Throws<DivideByZeroException>(() => calculator.Divide("5,0"));
        }
    }
}
