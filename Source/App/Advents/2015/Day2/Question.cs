using App.Common.Input;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day2
{
    /// <summary>
    /// https://adventofcode.com/2015/day/2
    /// </summary>
    public class Question : QuestionBase<int>
    {
        internal override int SolveSilver(string path)
        {
            var input = InputHelper.GetLines(path);

            var boxes = GetBoxes(input);

            var length = 0;
            foreach (var box in boxes)
            {
                length += box.GetAreaOfSmallestSide();
                length += box.GetSurfaceArea();
            }

            return length;
        }

        internal override int SolveGold(string path)
        {
            var input = InputHelper.GetLines(path);

            var boxes = GetBoxes(input);

            var length = 0;
            foreach (var box in boxes)
            {
                length += box.GetSmallestPerimeter();
                length += box.GetVolume();
            }

            return length;
        }

        private List<Box> GetBoxes(string[] input)
        {
            var boxes = new List<Box>();

            foreach (var line in input)
            {
                boxes.Add(GetBox(line));
            }

            return boxes;
        }

        private Box GetBox(string input)
        {
            var values = input.Trim().Split("x");

            return new Box(
                width: int.Parse(values[0]),
                length: int.Parse(values[1]),
                height: int.Parse(values[2]));
        }
    }
}
