using App.Advents._2015.Day7.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day7.Instructions
{
    internal class InstructionExecutorTests
    {
        private IInstructionExecutor _executor = new InstructionExecutor();

        [TestCaseSource(nameof(PossibleInstructions))]
        public void Execute_GivenInstruction_AndPossible_UpdatesValueMap(Instruction input, int expected)
        {
            // Assemble
            var valueMap = new Dictionary<string, ushort?>()
            {
                {
                    "test_output", null
                }
            };

            // Act
            _executor.Execute(input, valueMap);

            // Assert
            Assert.That(valueMap["test_output"], Is.EqualTo(expected));
        }

        [TestCaseSource(nameof(PossibleInstructions))]
        public void Execute_GivenInstruction_AndPossible_SetsInstructionToComplete(Instruction input, int _)
        {
            // Assemble
            var valueMap = new Dictionary<string, ushort?>();

            // Act
            _executor.Execute(input, valueMap);

            // Assert
            Assert.That(input.Complete, Is.EqualTo(true));
        }

        [TestCaseSource(nameof(ImpossibleInstructions))]
        public void Execute_GivenInstruction_AndNotPossible_DoesNotUpdateValueMap(Instruction input, int _)
        {
            // Assemble
            var valueMap = new Dictionary<string, ushort?>()
            {
                {
                    "test_output", null
                }
            };

            // Act
            _executor.Execute(input, valueMap);

            // Assert
            Assert.That(valueMap["test_output"], Is.EqualTo(null));
        }

        [TestCaseSource(nameof(ImpossibleInstructions))]
        public void Execute_GivenInstruction_AndNotPossible_DoesNotSetInstructionToComplete(Instruction input, int _)
        {
            // Assemble
            var valueMap = new Dictionary<string, ushort?>();

            // Act
            _executor.Execute(input, valueMap);

            // Assert
            Assert.That(input.Complete, Is.EqualTo(false));
        }

        [Test]
        public void Execute_GivenEntryInValueMap_UsesValue_AndExecutesAsExpected()
        {
            // Assemble
            var valueMap = new Dictionary<string, ushort?>()
            {
                {
                    "test_input", 5
                },
                {
                    "test_output", null
                }
            };
            var instruction = new Instruction(
                InstructionType.ASSIGN,
                "test_output",
                new[] { "test_input" });

            // Act
            _executor.Execute(instruction, valueMap);

            // Assert
            Assert.That(instruction.Complete, Is.EqualTo(true));
            Assert.That(valueMap["test_output"], Is.EqualTo(5));
        }

        [Test]
        public void Execute_GivenOutputInValueMap_DoesNotOverwriteValue_AndExecutesAsExpected()
        {
            // Assemble
            var valueMap = new Dictionary<string, ushort?>()
            {
                {
                    "test_output", 404
                }
            };
            var instruction = new Instruction(
                InstructionType.ASSIGN,
                "test_output",
                new[] { "5" });

            // Act
            _executor.Execute(instruction, valueMap);

            // Assert
            Assert.That(instruction.Complete, Is.EqualTo(true));
            Assert.That(valueMap["test_output"], Is.EqualTo(404));
        }

        private static IEnumerable<TestCaseData> ImpossibleInstructions
        {
            get
            {
                yield return new TestCaseData(
                    new Instruction(InstructionType.ASSIGN, "test_output", new[] { "impossible_input" }), int.MinValue);
                yield return new TestCaseData(
                    new Instruction(InstructionType.AND, "test_output", new[] { "impossible_input", "6" }), int.MinValue);
                yield return new TestCaseData(
                    new Instruction(InstructionType.OR, "test_output", new[] { "impossible_input", "6" }), int.MinValue);
                yield return new TestCaseData(
                    new Instruction(InstructionType.LSHIFT, "test_output", new[] { "impossible_input", "6" }), int.MinValue);
                yield return new TestCaseData(
                    new Instruction(InstructionType.RSHIFT, "test_output", new[] { "impossible_input", "6" }), int.MinValue);
                yield return new TestCaseData(
                    new Instruction(InstructionType.NOT, "test_output", new[] { "impossible_input" }), int.MinValue);
            }
        }

        private static IEnumerable<TestCaseData> PossibleInstructions
        {
            get
            {
                yield return new TestCaseData(
                    new Instruction(InstructionType.ASSIGN, "test_output", new[] {"5"}), 5);
                yield return new TestCaseData(
                    new Instruction(InstructionType.AND, "test_output", new[] { "5", "6" }), 4);
                yield return new TestCaseData(
                    new Instruction(InstructionType.OR, "test_output", new[] { "5", "6" }), 7);
                yield return new TestCaseData(
                    new Instruction(InstructionType.LSHIFT, "test_output", new[] { "5", "6" }), 320);
                yield return new TestCaseData(
                    new Instruction(InstructionType.RSHIFT, "test_output", new[] { "5", "6" }), 0);
                yield return new TestCaseData(
                    new Instruction(InstructionType.NOT, "test_output", new[] { "5" }), 65530);
            }
        }
    }
}
