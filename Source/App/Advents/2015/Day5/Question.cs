using App.Common.Abstractions;
using App.Common.Input;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day5
{
    /// <summary>
    /// https://adventofcode.com/2015/day/5
    /// </summary>
    public class Question : QuestionBase<int>
    {
        private IValidator<string> _validator = new NicenessValidator();

        internal override int SolveSilver(string path)
        {
            var input = InputHelper.GetLines(path);

            var count = 0;
            foreach (var line in input)
            {
                if (_validator.Validate(line)) count++;
            }

            return count;
        }

        internal override int SolveGold(string path)
        {
            throw new NotImplementedException();
        }
    }
}
