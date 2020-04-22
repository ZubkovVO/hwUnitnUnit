using CSharpCalculator;
using NUnit.Framework;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class DivideTest
    {
        [Test]
        public void Div_30per2_15returned()
        {
            //arrange
            double x = 30;
            double y = 2;
            double expected = 15;

            //act
            Calculator c = new Calculator();
            double actual = c.Divide(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        //[ExpectedException(typeof(DivideByZeroException), "Divide by zero attempted")]
        public void Div_by0_excpetionReturned()
        {
            //arrange
            double x = 30;
            double y = 0;

            //act
            Calculator c = new Calculator();
            double actual = c.Divide(x, y);

            //assert
            Assert.IsTrue(double.IsInfinity(actual));

        }
    }
}
