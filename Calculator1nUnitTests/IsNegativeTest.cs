using CSharpCalculator;
using NUnit.Framework;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class IsNegativeTest
    {
        [Test]
        public void isNegative_minus10_true()
        {
            //arrange
            double x = -10;

            //act
            Calculator c = new Calculator();
            bool actual = c.isNegative(x);

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void isNegative_10_false()
        {
            //arrange
            double x = 10;

            //act
            Calculator c = new Calculator();
            bool actual = c.isNegative(x);

            //assert
            Assert.IsFalse(actual);
        }
    }
}