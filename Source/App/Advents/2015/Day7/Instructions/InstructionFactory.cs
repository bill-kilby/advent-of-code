using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day7.Instructions
{
    public class InstructionFactory : IFactory<Instruction>
    {
        private string _input = string.Empty;

        public Instruction Create(string input)
        {
            _input = input;

            var instructionType = GetInstructionType();
            var inputs = GetInputs(instructionType);
            var output = GetOutput();

            return new Instruction(instructionType, output, inputs);
        }

        private string[] GetInputs(InstructionType instructionType)
        {
            var splits = _input.Split("->");
            var instruction = splits[0].Trim();

            switch (instructionType)
            {
                case InstructionType.ASSIGN:
                    return [instruction];

                case InstructionType.NOT:
                    var not = instruction.Replace("NOT", "").Trim();
                    return [not];

                case InstructionType.AND:
                    var andSplit = instruction.Split("AND");
                    return [andSplit[0].Trim(), andSplit[1].Trim()];

                case InstructionType.OR:
                    var orSplit = instruction.Split("OR");
                    return [orSplit[0].Trim(), orSplit[1].Trim()];

                case InstructionType.LSHIFT:
                    var lShiftSplit = instruction.Split("LSHIFT");
                    return [lShiftSplit[0].Trim(), lShiftSplit[1].Trim()];

                case InstructionType.RSHIFT:
                    var rShiftSplit = instruction.Split("RSHIFT");
                    return [rShiftSplit[0].Trim(), rShiftSplit[1].Trim()];

                default:
                    throw new NotImplementedException($"Unimplented instruction type found: {instructionType}");
            }
        }

        private InstructionType GetInstructionType()
        {
            if (_input.Contains("NOT")) return InstructionType.NOT;
            if (_input.Contains("AND")) return InstructionType.AND;
            if (_input.Contains("OR")) return InstructionType.OR;
            if (_input.Contains("LSHIFT")) return InstructionType.LSHIFT;
            if (_input.Contains("RSHIFT")) return InstructionType.RSHIFT;

            return InstructionType.ASSIGN;
        }

        private string GetOutput()
        {
            var split = _input.Split("->");
            return split[1].Trim();
        }
    }
}
