using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace UnitTestIngDotNet
{
    [TestClass]
    public class uT_TestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tc = new testClass();
           int actual;
           actual = tc.testSum(4, 6);
            var expected = 10;

            Assert.AreEqual(expected, actual);

        }
    }
}
