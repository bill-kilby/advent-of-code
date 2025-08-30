using App.Advents._2015.Day6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Common;

namespace Test.Advents._2015.Day6
{
    internal class QuestionTests : IQuestionTests<int>
    {
        [TestCase("2015/Day6/input.txt", 543903, 14687245)]
        [TestCase("2015/Day6/edge1.txt", 1000000, 2000000)]
        [TestCase("2015/Day6/edge2.txt", 1000, 14687245)]
        [TestCase("2015/Day6/edge3.txt", 0, 14687245)]
        [TestCase("2015/Day6/edge4.txt", 1, 1)]
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
