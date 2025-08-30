using App.Common.Exceptions;
using App.Common.Input;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day1
{
    /// <summary>
    /// https://adventofcode.com/2015/day/1
    /// </summary>
    public class Question : QuestionBase<int>
    {
        protected override int SolveSilver(string path)
        {
            var input = InputHelper.GetText(path);

            var floor = 0;
            foreach (var stair in input)
            {
                floor = UpdateFloor(floor, stair);
            }

            return floor;
        }

        protected override int SolveGold(string path)
        {
            var input = InputHelper.GetText(path);

            var floor = 0;
            var position = 0;
            foreach (var stair in input)
            {
                position++;

                floor = UpdateFloor(floor, stair);

                if (floor < 0) break;
            }

            return position;
        }

        private int UpdateFloor(int floor, char stair) => stair switch
        {
            '(' => floor + 1,
            ')' => floor - 1,
            _ => throw new InvalidCharacterException(stair)
        };
    }
}
