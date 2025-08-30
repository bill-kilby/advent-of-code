using App.Advents._2015.Day7;
using App.Advents._2015.Day7.Instructions;
using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day7
{
    internal class ValueMapFactoryTests
    {
        private IFactory<Dictionary<string, int>, Instruction[]> _factory = new ValueMapFactory();

        [Test]
        public void Create_MapsInputs()
        {
            // Assemble
            var inputs = new Instruction[]
            {
                new(InstructionType.ASSIGN, string.Empty, ["a", "b"])
            };

            // Act
            var result = _factory.Create(inputs);

            // Assert
            CollectionAssert.Contains(result.Keys, "a");
            CollectionAssert.Contains(result.Keys, "b");
        }

        [Test]
        public void Create_MapsOutputs()
        {
            // Assemble
            var inputs = new Instruction[]
            {
                new(InstructionType.ASSIGN, "c", Array.Empty<string>())
            };

            // Act
            var result = _factory.Create(inputs);

            // Assert
            CollectionAssert.Contains(result.Keys, "c");
        }
    }
}
