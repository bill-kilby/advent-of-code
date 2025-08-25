using App.Advents._2015.Day5;
using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day5
{
    internal class NicenessValidatorTests
    {
        private IValidator<string> _validator = new NicenessValidator();

        [Test]
        public void Validate_WithValidString_ShouldBeTrue()
        {
            // Assemble
            var input = "aaeiou";

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Validate_WithoutThreeVowels_ShouldBeFalse()
        {
            // Assemble
            var input = "aa";

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Validate_WithoutDoubleLetters_ShouldBeFalse()
        {
            // Assemble
            var input = "aei";

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Validate_WithNaughtyStrings_ShouldBeFalse()
        {
            // Assemble
            var input = "aaabaei";

            // Act
            var result = _validator.Validate(input);

            // Assert
            Assert.That(result, Is.EqualTo(false));
        }

        [TestCase("ugknbfddgicrmopn", true)]
        [TestCase("aaa", true)]
        [TestCase("jchzalrnumimnmhp", false)]
        [TestCase("haegwjzuvuyypxyu", false)]
        [TestCase("dvszwmarrgswjxmb", false)]
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
