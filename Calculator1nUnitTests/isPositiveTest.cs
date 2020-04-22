using CSharpCalculator;
using NUnit.Framework;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class isPositiveTest
    {
        [Test]
        public void isPositive_12_true()
        {
            //arrange
            double x = 12;

            //act
            Calculator c = new Calculator();
            bool actual = c.isPositive(x);

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void isPostive_minus12_false()
        {
            //arrange
            double x = -12;

            //act
            Calculator c = new Calculator();
            bool actual = c.isPositive(x);

            //assert
            Assert.IsFalse(actual);
        }
    }
}