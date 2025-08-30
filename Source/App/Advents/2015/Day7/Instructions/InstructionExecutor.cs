using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day7.Instructions
{
    public class InstructionExecutor : IInstructionExecutor
    {
        private Dictionary<string, int> _map = new();

        public void Execute(Instruction instruction, Dictionary<string, int> valueMap)
        {
            _map = valueMap;

            var inputs = GetInputs(instruction.Inputs);
            if (inputs == null) return;

            int result;
            switch (instruction.InstructionType)
            {
                case InstructionType.ASSIGN:
                    result = Assign(inputs[0]);
                    break;
                case InstructionType.NOT:
                    result = Not(inputs[0]);
                    break;
                case InstructionType.AND:
                    result = And(inputs[0], inputs[1]);
                    break;
                case InstructionType.OR:
                    result = Or(inputs[0], inputs[1]);
                    break;
                case InstructionType.LSHIFT:
                    result = LShift(inputs[0], inputs[1]);
                    break;
                case InstructionType.RSHIFT:
                    result = RShift(inputs[0], inputs[1]);
                    break;
                default:
                    throw new NotImplementedException($"Unimplemented instruction type found: {instruction.InstructionType}.");
            }

            instruction.Complete = true;
            _map[instruction.Output] = result;
        }

        private int Assign(int a) => a;
        private int Not(int a) => ~a;
        private int And(int a, int b) => a & b;
        private int Or(int a, int b) => a | b;
        private int LShift(int a, int b) => a << b;
        private int RShift(int a, int b) => a >> b;

        private int[]? GetInputs(string[] inputs)
        {
            var intputs = new List<int>();

            foreach (var intput in inputs)
            {
                var value = GetValue(intput);

                if (value == null) return null;

                intputs.Add((int) value);
            }

            return intputs.ToArray();
        }

        private int? GetValue(string value)
        {
            try
            {
                return int.Parse(value);
            }
            catch
            {
                if (_map.ContainsKey(value))
                {
                    return _map[value];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
