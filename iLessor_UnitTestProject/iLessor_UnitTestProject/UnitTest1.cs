using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iLessor_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnActual()
        {
            int firstValue = 20;
            int secondValue = 2;
            int sum = firstValue/secondValue;

            Assert.AreEqual(12, sum);
        }

        [TestMethod]
        public void GetName()
        {
            string name = "Mark";
            Assert.AreEqual("Mark", name);
        }
    }
}
