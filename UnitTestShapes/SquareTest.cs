using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mySq = new Square(4);
            Assert.AreEqual(16, mySq.Area());
            Assert.AreEqual(16, mySq.Perimeter());
        }
    }
}
