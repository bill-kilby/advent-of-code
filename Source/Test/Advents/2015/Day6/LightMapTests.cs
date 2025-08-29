using App.Advents._2015.Day6;
using App.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day6
{
    internal class LightMapTests
    {
        private ILightMap _map;

        [SetUp]
        public void Before()
        {
            _map = new LightMap();
        }

        [Test]
        public void Toggle_WhenLightOff_TurnsOnLight()
        {
            // Assemble

            // Act
            _map.Toggle(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(1));
        }

        [Test]
        public void Toggle_WhenLightOn_TurnsOffLight()
        {
            // Assemble
            _map.Toggle(new Vector2Int(0, 0));

            // Act
            _map.Toggle(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(0));
        }

        [Test]
        public void GetTotalLitLights_ReturnsTotalLitLight()
        {
            // Assemble

            // Act
            _map.Toggle(new Vector2Int(0, 0));
            _map.Toggle(new Vector2Int(1, 0));
            _map.Toggle(new Vector2Int(2, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(3));
        }
    }
}
