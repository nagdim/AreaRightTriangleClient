using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleLogic;

namespace TriangleLogicTest
{
    [TestFixture]
    public class AreaTriangleToolsTest
    {
        [Test]
        public void VerifySidesTriangleCorrect()
        {
            Assert.Throws<ArgumentException>(() => AreaTriangleTools.SquareRightTriangle(3, 4, -1));
            Assert.Throws<ArgumentException>(() => AreaTriangleTools.SquareRightTriangle(3,-1, 5));
            Assert.Throws<ArgumentException>(() => AreaTriangleTools.SquareRightTriangle(-1, 4, 5));

        }

        [Test]
        public void VerifyTriangleThatRectangular()
        {
            Assert.Throws<AggregateException>(() => AreaTriangleTools.SquareRightTriangle(5, 4, 4));
        }
    }
}
