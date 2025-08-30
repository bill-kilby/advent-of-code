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
        public void HardToggle_WhenLightOff_TurnsOnLight()
        {
            // Assemble

            // Act
            _map.HardToggle(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(1));
        }

        [Test]
        public void HardToggle_WhenLightOn_TurnsOffLight()
        {
            // Assemble
            _map.HardToggle(new Vector2Int(0, 0));

            // Act
            _map.HardToggle(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(0));
        }

        [Test]
        public void GetTotalLitLights_ReturnsTotalLitLight()
        {
            // Assemble

            // Act
            _map.HardToggle(new Vector2Int(0, 0));
            _map.HardToggle(new Vector2Int(1, 0));
            _map.HardToggle(new Vector2Int(2, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(3));
        }

        [Test]
        public void TurnOn_TurnsOnLight()
        {
            // Assemble

            // Act
            _map.TurnOn(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(1));
        }

        [Test]
        public void TurnOff_TurnsOffLight()
        {
            // Assemble
            _map.TurnOn(new Vector2Int(0, 0));

            // Act
            _map.TurnOff(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalLitLights(), Is.EqualTo(0));
        }

        [Test]
        public void GetTotalBrightness_GetsTotalBrightness()
        {
            // Assemble

            // Act
            _map.TurnOn(new Vector2Int(0, 0));
            _map.TurnOn(new Vector2Int(0, 0));
            _map.TurnOn(new Vector2Int(0, 0));
            _map.TurnOn(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalBrightness(), Is.EqualTo(4));
        }

        [Test]
        public void IncreaseToggle_IncreasesBrightnessByTwo()
        {
            // Assemble

            // Act
            _map.IncreaseToggle(new Vector2Int(0, 0));

            // Assert
            Assert.That(_map.GetTotalBrightness(), Is.EqualTo(2));
        }
    }
}
