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
        private IBox? _box;

        [Test]
        public void GetAreaOfSmallestSide_ReturnsSmallestSide()
        {
            // Assemble
            _box = new Box(width: 1, length: 2, height: 3);

            // Act
            var result = _box.GetAreaOfSmallestSide();

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetSurfaceArea_ReturnsSurfaceArea()
        {
            // Assemble
            _box = new Box(width: 1, length: 1, height: 1);

            // Act
            var result = _box.GetSurfaceArea();

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void GetVolume_ReturnsVolume()
        {
            // Assemble
            _box = new Box(width: 2, length: 2, height: 2);

            // Act
            var result = _box.GetVolume();

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void GetSmallestPerimeter_ReturnsSmallestPerimeter()
        {
            // Assemble
            _box = new Box(width: 1, length: 2, height: 3);

            // Act
            var result = _box.GetSmallestPerimeter();

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
    }
}
