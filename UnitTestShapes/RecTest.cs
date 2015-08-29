using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RecTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myRec = new Rectangle(5, 2);
            Assert.AreEqual(2, myRec.Right);
            Assert.AreEqual(10, myRec.Area());
        }

    } 
}
