using System;
using Calculator;
using NUnit.Framework;

namespace TestCalculator
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            CCalculator c1 = new CCalculator();
            Assert.True(c1.Add(4,5)==9);
        }
        [Test]
        public void Test2()
        {
            Assert.True(true);
        }
    }
}