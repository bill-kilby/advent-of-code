using App.Advents._2015.Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day9
{
    internal class TargetMapPermutatorTests
    {
        private TargetMapPermutator permutator = new();
        private CitySourceTargetMap map;

        [SetUp]
        public void Before()
        {
            map = new();
        }

        [Test]
        public void GetRoutes_GivenPossibleRoutes_ReturnsAllPossibleRoutes()
        {
            // Assemble
            map.AddTargetToCity("A", "B", 10);
            map.AddTargetToCity("C", "D", 10);

            // Act
            var routes = permutator.GetRoutes(map, "A", "D");

            // Assert
            Assert.That(routes.Count, Is.EqualTo(5));
        }

        [Test]
        public void GetRoutes_GivenNoPossibleRoutes_ReturnsEmptyList()
        {
            // Assemble

            // Act
            var routes = permutator.GetRoutes(map, "A", "D");

            // Assert
            Assert.That(routes.Count, Is.Empty);
        }
    }
}
