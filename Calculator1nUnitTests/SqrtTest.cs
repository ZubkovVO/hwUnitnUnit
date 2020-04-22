using CSharpCalculator;
using NUnit.Framework;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class SqrtTest
    {
        [Test]
        public void Sqrt_from16_4returned()
        {
            //arrange
            double x = 16;
            double expected = 4;

            //act
            Calculator c = new Calculator();
            double actual = c.Sqrt(x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
