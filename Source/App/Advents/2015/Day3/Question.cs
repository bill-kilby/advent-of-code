using App.Common.Exceptions;
using App.Common.Input;
using App.Common.Math;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day3
{
    /// <summary>
    /// https://adventofcode.com/2015/day/3
    /// </summary>
    public class Question : QuestionBase<int>
    {
        private Dictionary<Vector2Int, int> _visited;

        private Vector2Int _santaPos;

        internal override int SolveSilver(string path)
        {
            var input = InputHelper.GetText(path);

            _santaPos = new();
            _visited = new();
            foreach (var move in input)
            {
                HandleMove(move);

                DeliverPresent();
            }

            return _visited.Count;
        }

        internal override int SolveGold(string path)
        {
            throw new NotImplementedException();
        }

        private void DeliverPresent()
        {
            if (!_visited.ContainsKey(_santaPos))
            {
                _visited.Add(_santaPos, 0);
            }

            _visited[_santaPos]++;
        }

        private void HandleMove(char move)
        {
            switch (move)
            {
                case '^':
                    _santaPos.Y++;
                    break;
                case 'v':
                    _santaPos.Y--;
                    break;
                case '<':
                    _santaPos.X--;
                    break;
                case '>':
                    _santaPos.X++;
                    break;
                default:
                    throw new InvalidCharacterException(move);
            }
        }
    }
}
