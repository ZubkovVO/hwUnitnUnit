using CSharpCalculator;
using NUnit.Framework;
using System;

namespace Calculator1nUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class SubTest
    {
        [SetUp] public void Init() 
        {
            Console.WriteLine("Initializing tests for substract method");
        }
        

        [Test]
        public void Sub_15from30_15returned()
        {
            //arrange
            double x = 30;
            double y = 15;
            double expected = 15;

            //act
            Calculator c = new Calculator();
            double actual = c.Sub(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TearDown] public void Cleanup()
        {
            Console.WriteLine("Substract tests finished");
        }

    }
}
