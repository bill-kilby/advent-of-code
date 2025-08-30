using App.Advents._2015.Day7.Instructions;
using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day7.Instructions
{
    internal class InstructionFactoryTests
    {
        private IFactory<Instruction> _factory = new InstructionFactory();

        [TestCase("123 -> x", InstructionType.ASSIGN)]
        [TestCase("x AND y -> d", InstructionType.AND)]
        [TestCase("x OR y -> e", InstructionType.OR)]
        [TestCase("x LSHIFT 2 -> f", InstructionType.LSHIFT)]
        [TestCase("y RSHIFT 2 -> g", InstructionType.RSHIFT)]
        [TestCase("NOT x -> h", InstructionType.NOT)]
        public void Create_GivenInstructionType_SetsInstructionType(string input, InstructionType expected)
        {
            // Assemble

            // Act
            var result = _factory.Create(input);

            // Assert
            Assert.That(result.InstructionType, Is.EqualTo(expected));
        }

        [TestCase("123 -> x", new[] {"123"})]
        [TestCase("x OR y -> e", new[] { "x", "y" })]
        [TestCase("NOT x -> h", new[] { "x" })]
        public void Create_GivenInstructionType_SetsInputs(string input, string[] expected)
        {
            // Assemble

            // Act
            var result = _factory.Create(input);

            // Assert
            CollectionAssert.AreEqual(expected, result.Inputs);
        }

        [Test]
        public void Create_SetsOutputs()
        {
            // Assemble
            var input = "123 -> x";
            var expected = "123";

            // Act
            var result = _factory.Create(input);

            // Assemble
            Assert.That(result.Output, Is.EqualTo(expected));
        }
    }
}
