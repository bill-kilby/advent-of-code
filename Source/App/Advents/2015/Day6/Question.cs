using App.Advents._2015.Day6.Instructions;
using App.Common.Abstractions;
using App.Common.Input;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Advents._2015.Day6;

namespace App.Advents._2015.Day6
{
    /// <summary>
    /// https://adventofcode.com/2015/day/6
    /// </summary>
    public class Question : QuestionBase<int>
    {
        private ILightMap _map = new LightMap();
        private IFactory<Instruction> _instructionFactory = new InstructionFactory();

        internal override int SolveSilver(string path)
        {
            _map = new LightMap();

            var input = InputHelper.GetLines(path);

            foreach (var line in input)
            {
                var instruction = _instructionFactory.Create(line);
                DoInstruction(instruction);
            }

            return _map.GetTotalLitLights();
        }

        internal override int SolveGold(string path)
        {
            throw new NotImplementedException();
        }

        private void DoInstruction(Instruction instruction)
        {
            foreach (var light in instruction.AffectedLights)
            {
                switch (instruction.InstructionType)
                {
                    case InstructionType.TurnOn:
                        _map.TurnOn(light);
                        break;
                    case InstructionType.TurnOff:
                        _map.TurnOff(light);
                        break;
                    case InstructionType.Toggle:
                        _map.Toggle(light);
                        break;
                    default:
                        throw new NotImplementedException(
                            $"Unknown instruction type is unimplemented: {instruction.InstructionType}.");
                }
            }
        }
    }
}
