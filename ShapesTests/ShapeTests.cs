using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestShapes
{
    [TestClass]
    public class AbstractShapeTests
    {
        private class MyMockShape : Shape
        {
            public override float Area()
            {
                throw new NotImplementedException();
            }
            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }

        MyMockShape omgMyShape = new MyMockShape();

        [TestMethod()]
        public void TestThatAbstractShapeClassHasFillColor()
        {
            omgMyShape.FillColor = Color.PapayaWhip;
            Assert.Fail();
        }
    }
}