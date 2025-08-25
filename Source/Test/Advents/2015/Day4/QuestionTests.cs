using App.Advents._2015.Day4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Common;

namespace Test.Advents._2015.Day4
{
    internal class QuestionTests : IQuestionTests<int>
    {
        [TestCase("2015/Day4/input.txt", 117946, 3938038)]
        [TestCase("2015/Day4/edge1.txt", 609043, 0)]
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
