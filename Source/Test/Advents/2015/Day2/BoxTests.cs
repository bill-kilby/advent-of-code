using App.Advents._2015.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day2
{
    internal class BoxTests
    {
        [Test]
        public void GetAreaOfSmallestSide_ReturnsSmallestSide()
        {
            // Assemble
            var box = new Box(width: 1, length: 2, height: 3);

            // Act
            var result = box.GetAreaOfSmallestSide();

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetSurfaceArea_ReturnsSurfaceArea()
        {
            // Assemble
            var box = new Box(width: 1, length: 1, height: 1);

            // Act
            var result = box.GetSurfaceArea();

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
    }
}
