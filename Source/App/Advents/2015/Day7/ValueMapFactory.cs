using App.Advents._2015.Day7.Instructions;
using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day7
{
    public class ValueMapFactory : IFactory<Dictionary<string, int>, Instruction[]>
    {
        private Dictionary<string, int> _map = new();

        public Dictionary<string, int> Create(Instruction[] input)
        {
            _map = new();

            foreach (var instruction in input)
            {
                MapInstruction(instruction);
            }

            return _map;
        }

        private void MapInstruction(Instruction instruction)
        {
            foreach (var input in instruction.Inputs)
            {
                if (!_map.Keys.Contains(input))
                    _map.Add(input, int.MinValue);
            }

            if (!_map.Keys.Contains(instruction.Output))
                _map.Add(instruction.Output, int.MinValue);
        }
    }
}
