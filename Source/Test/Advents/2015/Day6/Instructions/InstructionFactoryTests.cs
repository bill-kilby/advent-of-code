using App.Advents._2015.Day6.Instructions;
using App.Common.Abstractions;
using App.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day6.Instructions
{
    internal class InstructionFactoryTests
    {
        IFactory<Instruction> _factory = new InstructionFactory();

        [TestCase("turn on 0,0 through 0,0", InstructionType.TurnOn)]
        [TestCase("turn off 0,0 through 0,0", InstructionType.TurnOff)]
        [TestCase("toggle 0,0 through 0,0", InstructionType.Toggle)]
        public void Create_GivenInstructionType_SetsInstructionType(string input, InstructionType expected)
        {
            // Assemble

            // Act
            var result = _factory.Create(input);

            // Assert
            Assert.That(result.InstructionType, Is.EqualTo(expected));
        }

        [Test]
        public void Create_SetsExpectedLights()
        {
            // Assemble
            var input = "turn on 0,0 through 3,3";
            var expected = new Vector2Int[]
            {
                new(0,0), new(1, 0), new(2, 0),
                new(0,1), new(1, 1), new(2, 1),
                new(0,2), new(1, 2), new(2, 2),
            };

            // Act
            var result = _factory.Create(input);

            // Assert
            Assert.That(result.AffectedLights.Count(), Is.EqualTo(9));
            CollectionAssert.AreEquivalent(expected, result.AffectedLights);
        }
    }
}
