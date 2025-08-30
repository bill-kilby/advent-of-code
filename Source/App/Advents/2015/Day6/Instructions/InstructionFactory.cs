using App.Common.Abstractions;
using App.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day6.Instructions
{
    public class InstructionFactory : IFactory<Instruction, string>
    {
        private string _input = string.Empty;

        public Instruction Create(string input)
        {
            _input = input;

            var instructionType = GetAndRemoveInstructionType();
            var affectedLights = GetAffectedLights();

            return new Instruction(instructionType, affectedLights);
        }

        private Vector2Int[] GetAffectedLights()
        {
            var lights = new List<Vector2Int>();

            var split = _input.Split(" through ");

            var from = Vector2Int.Parse(split[0].Trim());
            var to = Vector2Int.Parse(split[1].Trim());

            var dx = from.X - to.X;
            var dy = from.Y - to.Y;
            for (var x = from.X; x <= to.X; x++)
            {
                for (var y = from.Y; y <= to.Y; y++)
                {
                    lights.Add(new Vector2Int(x, y));
                }
            }

            return lights.ToArray();
        }

        private InstructionType GetAndRemoveInstructionType()
        {
            if (_input.Contains("turn on"))
            {
                _input = _input.Replace("turn on ", "");
                return InstructionType.TurnOn;
            }
            if (_input.Contains("turn off"))
            {
                _input = _input.Replace("turn off ", "");
                return InstructionType.TurnOff;
            }
            if (_input.Contains("toggle"))
            {
                _input = _input.Replace("toggle ", "");
                return InstructionType.Toggle;
            }

            throw new NotImplementedException($"Input contains unimplemented instruction type: {_input}");
        }
    }
}
