using App.Advents._2015.Day2;
using Test.Common;

namespace Test.Advents._2015.Day2
{
    internal class QuestionTests : IQuestionTests<int>
    {
        [TestCase("2015/Day2/input.txt", 1588178, 3783758)]
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
