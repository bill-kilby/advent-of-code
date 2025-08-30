using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day7.Instructions
{
    public class InstructionExecutor : IInstructionExecutor
    {
        private Dictionary<string, ushort?> _map = new();

        public void Execute(Instruction instruction, Dictionary<string, ushort?> valueMap)
        {
            _map = valueMap;

            var inputs = GetInputs(instruction.Inputs);
            if (inputs == null) return;

            ushort result;
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

        private ushort Assign(ushort a) => (ushort) a;
        private ushort Not(ushort a) => (ushort) ~a;
        private ushort And(ushort a, ushort b) => (ushort) (a & b);
        private ushort Or(ushort a, ushort b) => (ushort) (a | b);
        private ushort LShift(ushort a, ushort b) => (ushort) (a << b);
        private ushort RShift(ushort a, ushort b) => (ushort) (a >> b);

        private ushort[]? GetInputs(string[] inputs)
        {
            var intputs = new List<ushort>();

            foreach (var intput in inputs)
            {
                var value = GetValue(intput);

                if (value == null) return null;

                intputs.Add((ushort) value);
            }

            return intputs.ToArray();
        }

        private ushort? GetValue(string value)
        {
            if (ushort.TryParse(value, out var number))
            {
                return number;
            }

            if (_map.TryGetValue(value, out var mappedValue))
            {
                return mappedValue;
            }

            return null;
        }
    }
}
