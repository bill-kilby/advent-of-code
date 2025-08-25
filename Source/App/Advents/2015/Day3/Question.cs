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
        private Dictionary<Vector2Int, int> _visited = new();

        private Vector2Int _santaPos = new();
        private Vector2Int _evilSantaPos = new();

        internal override int SolveSilver(string path)
        {
            var input = InputHelper.GetText(path);

            _santaPos = new();
            _visited = new();

            DeliverPresent(_santaPos);
            foreach (var move in input)
            {
                _santaPos = UpdatePosition(_santaPos, move);

                DeliverPresent(_santaPos);
            }

            return _visited.Count;
        }

        internal override int SolveGold(string path)
        {
            var input = InputHelper.GetText(path);

            _santaPos = new();
            _evilSantaPos = new();
            _visited = new();
             
            var evil = false;

            DeliverPresent(_santaPos);
            DeliverPresent(_evilSantaPos);
            foreach (var move in input)
            {
                if (evil)
                {
                    _evilSantaPos = UpdatePosition(_evilSantaPos, move);
                    DeliverPresent(_evilSantaPos);
                    evil = false;
                } 
                else
                {
                    _santaPos = UpdatePosition(_santaPos, move);
                    DeliverPresent(_santaPos);
                    evil = true;
                }
            }

            return _visited.Count;
        }

        private void DeliverPresent(Vector2Int pos)
        {
            if (!_visited.ContainsKey(pos))
            {
                _visited.Add(pos, 0);
            }

            _visited[pos]++;
        }

        private Vector2Int UpdatePosition(Vector2Int pos, char move)
        {
            switch (move)
            {
                case '^':
                    return pos + Vector2Int.Up;
                case 'v':
                    return pos + Vector2Int.Down;
                case '>':
                    return pos + Vector2Int.Left;
                case '<':
                    return pos + Vector2Int.Right;
                default:
                    throw new InvalidCharacterException(move);
            }
        }
    }
}
