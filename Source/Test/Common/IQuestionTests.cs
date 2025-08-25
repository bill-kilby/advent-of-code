using App.Advents._2015.Day1;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Common
{
    internal interface IQuestionTests<T>
    {
        internal void SolvingQuestion_ReturnsCorrectResult(string path, T silverAnswer, T silverResult);
    }
}
