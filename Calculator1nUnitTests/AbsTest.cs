using CSharpCalculator;
using NUnit.Framework;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class AbsTest
    {
        [Test]
        public void Abs_10positive_10returned()
        {
            //arrange
            double x = 10;
            double expected = 10;

            //act
            Calculator c = new Calculator();
            double actual = c.Abs(x);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Abs_10negative_10returned()
        {
            //arrange
            double x = -10;
            double expected = 10;

            //act
            Calculator c = new Calculator();
            double actual = c.Abs(x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
