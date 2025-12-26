using App.Advents._2015.Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day9
{
    internal class CitySourceTargetMapTests
    {
        private CitySourceTargetMap map;

        [SetUp]
        public void Before()
        {
            map = new();
        }

        [Test]
        public void AddTargetToCity_GivenNoExistingEntry_AddsCity()
        {
            // Assemble

            // Act
            map.AddTargetToCity("BKCity", "BKVillage", 10);
            var targets = map.GetCityTargets("BKCity");

            // Assert
            Assert.That(targets, Is.Not.Null);
            Assert.That(targets.Count, Is.EqualTo(1));

            Assert.That(targets[0].City, Is.EqualTo("BKVillage"));
            Assert.That(targets[0].Cost, Is.EqualTo(10));
        }

        [Test]
        public void AddTargetToCity_GivenExistingEntry_AddsCity()
        {
            // Assemble
            map.AddTargetToCity("BKCity", "BKTown", 10);

            // Act
            map.AddTargetToCity("BKCity", "BKVillage", 10);
            var targets = map.GetCityTargets("BKCity");

            // Assert
            Assert.That(targets, Is.Not.Null);
            Assert.That(targets.Count, Is.EqualTo(2));

            Assert.That(targets[0].City, Is.EqualTo("BKTown"));
            Assert.That(targets[0].Cost, Is.EqualTo(10));

            Assert.That(targets[1].City, Is.EqualTo("BKVillage"));
            Assert.That(targets[1].Cost, Is.EqualTo(10));
        }

        [Test]
        public void GetPossibleCities_GivenNoCities_ReturnsEmpty()
        {
            // Assemble

            // Act
            var cities = map.GetPossibleCities();

            // Assert
            Assert.That(cities, Is.Not.Null);
            Assert.That(cities.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetPossibleCities_GivenCities_ReturnsAllPossibleCities()
        {
            // Assemble
            map.AddTargetToCity("BKCity", "BKTown", 10);
            map.AddTargetToCity("BKCity", "BKVillage", 10);

            // Act
            var cities = map.GetPossibleCities();

            // Assert
            Assert.That(cities, Is.Not.Null);
            Assert.That(cities.Count, Is.EqualTo(3));

            Assert.Contains("BKCity", cities);
            Assert.Contains("BKTown", cities);
            Assert.Contains("BKVillage", cities);
        }

        [Test]
        public void GetPossibleCities_GivenDuplicateCities_ReturnsAllPossibleCities()
        {
            // Assemble
            map.AddTargetToCity("BKCity", "BKTown", 10);
            map.AddTargetToCity("BKCity", "BKVillage", 10);
            map.AddTargetToCity("BKTown", "BKCity", 10);

            // Act
            var cities = map.GetPossibleCities();

            // Assert
            Assert.That(cities, Is.Not.Null);
            Assert.That(cities.Count, Is.EqualTo(3));

            Assert.Contains("BKCity", cities);
            Assert.Contains("BKTown", cities);
            Assert.Contains("BKVillage", cities);
        }
    }
}
