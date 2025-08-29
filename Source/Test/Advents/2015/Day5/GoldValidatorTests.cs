using App.Advents._2015.Day5;
using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day5
{
    internal class GoldValidatorTests
    {
        private IValidator<string> _validator = new GoldValidator();

        [Test]
        public void Validate_WithValidString_ShouldBeTrue()
        {
            // Assemble
            var input = "aaaxaaa";

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Validate_WithoutNonOverlappingDoubleLetters_ShouldBeFalse()
        {
            // Assemble
            var input = "axa";

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Validate_WithoutRepeatedSpacedLetter_ShouldBeFalse()
        {
            // Assemble
            var input = "aaxbb";

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [TestCase("qjhvhtzxzqqjkmpb", true)]
        [TestCase("xxyxx", true)]
        [TestCase("uurcxstgmygtbstg", false)]
        [TestCase("ieodomkazucvgmuy", false)]
        public void Validate_GivenExampleInputs_ShouldBeExpectedOutputs(string input, bool expected)
        {
            // Assemble

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
