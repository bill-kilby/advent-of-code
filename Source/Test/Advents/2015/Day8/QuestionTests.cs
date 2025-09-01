using App.Advents._2015.Day8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Common;

namespace Test.Advents._2015.Day8
{
    internal class QuestionTests : IQuestionTests<int>
    {
        [TestCase("2015/Day8/input.txt", 1333, 2046)]
        [TestCase("2015/Day8/edge1.txt", 2, 9)]
        [TestCase("2015/Day8/edge2.txt", 3, 16)]
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
