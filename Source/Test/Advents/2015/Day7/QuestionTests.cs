using App.Advents._2015.Day7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Common;

namespace Test.Advents._2015.Day7
{
    internal class QuestionTests : IQuestionTests<int>
    {
        [TestCase("2015/Day7/input.txt", 956, 40149)]
        [TestCase("2015/Day7/edge1.txt", 65079, 65079)]
        [TestCase("2015/Day7/edge2.txt", 28, 28)]
        [TestCase("2015/Day7/edge3.txt", 30, 7)]
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
