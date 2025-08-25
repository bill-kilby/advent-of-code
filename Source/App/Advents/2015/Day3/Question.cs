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
        private HashSet<Vector2Int> _visited = new();

        private Vector2Int _santaPos;
        private Vector2Int _evilSantaPos;

        internal override int SolveSilver(string path)
        {
            var input = InputHelper.GetText(path);

            Setup();

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

            Setup();
             
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

        private void Setup()
        {
            _santaPos = new();
            _evilSantaPos = new();
            _visited = new();
        }

        private void DeliverPresent(Vector2Int pos) => _visited.Add(pos);

        private Vector2Int UpdatePosition(Vector2Int pos, char move) => move switch
        {
            '^' => pos + Vector2Int.Up,
            'v' => pos + Vector2Int.Down,
            '>' => pos + Vector2Int.Left,
            '<' => pos + Vector2Int.Right,
            _ => throw new InvalidCharacterException(move),
        };
    }
}
