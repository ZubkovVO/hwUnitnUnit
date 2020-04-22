using CSharpCalculator;
using NUnit.Framework;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class PowTest
    {
        [Test]
        public void Pow_2and2_4returned()
        {
            //arrange
            var x = 2;
            var y = 2;
            var expected = 4;

            //act
            Calculator c = new Calculator();
            var actual = c.Pow(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
