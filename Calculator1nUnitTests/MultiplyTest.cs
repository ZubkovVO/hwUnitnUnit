using CSharpCalculator;
using NUnit.Framework;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class MultiplyTest
    {
        [Test]
        public void Mult_5and5_25returned()
        {
            //arrange
            double x = 5;
            double y = 5;
            double expected = 25;

            //act
            Calculator c = new Calculator();
            double actual = c.Multiply(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
