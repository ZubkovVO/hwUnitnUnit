using CSharpCalculator;
using NUnit.Framework;
using System.Collections;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class AddTest
    {

        [TestCaseSource(typeof(TestDataClass), "TestCases")]
        public double DivideTest(double x, double y)
        {
            Calculator c = new Calculator();
            return c.Add(x, y);
        }
    }

    public class TestDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(12, 3).Returns(15);
                yield return new TestCaseData(12, 2).Returns(14);
                yield return new TestCaseData(12, 4).Returns(16);
            }
        }

       /* [Test]
        public void Add_10and20_30returned()
        {
            //arrange
            double x = 10;
            double y = 20;
            double expected = 30;

            //act
            Calculator c = new Calculator();
            double actual = c.Add(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }*/
    }
}
