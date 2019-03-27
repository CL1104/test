using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit2015;


namespace Unit2015.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void GetSumTest()
        {
            Assert.IsTrue(Calculate.GetSum(10) == 55);
        }

        [TestMethod()]
        public void GetSum1Test()
        {
            Assert.IsTrue(Calculate.GetSum(10) == 56);
        }
    }
}