using NUnit.Framework;
using QACalculator;
using System;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void AddTest_ShouldReturnZero_IfStringEmpty()
        {
            var calculator = new Calculator();
            int expectedResult = 0;
            int actual = calculator.Add("");
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        public void AddTest_ShouldReturnParsedNumber_IfStringIsJustANumber()
        {
            var calculator = new Calculator();
            int expectedResult = 5;
            int actual = calculator.Add("5");
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        public void AddTest_ShouldReturnCorrectValue_IfStringIsTwoNUmbersSeperatedByAComma()
        {
            var calculator = new Calculator();
            int expectedResult = 12;
            int actual = calculator.Add("5,7");
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        public void subtractTest()
        {
            var calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Subtract("5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void subtract2Test()
        {
            var calculator = new Calculator();
            int expected = -8;
            int actual = calculator.Subtract("-5,3");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void subtract3Test()
        {
            var calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Subtract("4,2");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void divide()
        {
            var calculator = new Calculator();
            int expected = 5;
            int actual = calculator.Divide("10,2");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void divide2()
        {
            var calculator = new Calculator();
            int expected = -5;
            int actual = calculator.Divide("10,-2");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void multiply()
        {
            var calculator = new Calculator();
            int expected = 50;
            int actual = calculator.Multiply("25,2");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void multiply2()
        {
            var calculator = new Calculator();
            int expected = 600;
            int actual = calculator.Multiply("150,4");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void dividewithsomeexception()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide("10,0"));
        }
    }
}
