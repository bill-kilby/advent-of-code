using App.Advents._2015.Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Common;

namespace Test.Advents._2015.Day3
{
    internal class QuestionTests : IQuestionTests<int>
    {
        [TestCase("2015/Day3/input.txt", 2565, 2639)]
        public void SolvingQuestion_ReturnsCorrectResult(string path, int silverAnswer, int goldAnswer)
        {
            // Assemble
            var question = new Question();

            // Act
            var answer = question.Solve(path);

            // Assert
            Assert.That(answer.Silver, Is.EqualTo(silverAnswer));
            Assert.That(answer.Gold, Is.EqualTo(goldAnswer));
        }
    }
}
