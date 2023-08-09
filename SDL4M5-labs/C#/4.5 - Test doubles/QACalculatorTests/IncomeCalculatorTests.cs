using System;
using FakeItEasy;
using NUnit.Framework;
using QACalculator;

namespace QACalculatorTests
{
    public class IncomeCalculatorTests
    {
        private ICalcMethod calcMethod;
        private IncomeCalculator calc;

        [SetUp]
        public void SetUp ()
        {
            //Set up the Mock
            calcMethod = A.Fake<ICalcMethod>();
        }

        [Test]
        [TestCase(Position.BOSS, 70000.0)]
        [TestCase(Position.PROGRAMMER, 50000.0)]
        public void TestCalc(Position position, double expectedIncome)
        {
            // arrange
            calc = new IncomeCalculator();

            // set up how the mock should behave
            A.CallTo(() => calcMethod.Calc(position)).Returns(expectedIncome);

            calc.SetCalcMethod(calcMethod);
            calc.SetPosition(position);

            // act
            var result = calc.Calc();

            // assert
            Assert.AreEqual(expectedIncome, result);
            A.CallTo(() => calcMethod.Calc(position)).MustHaveHappened(1, Times.Exactly);
        }
    }
}
