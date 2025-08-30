using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day7.Instructions
{
    public class Instruction(InstructionType instructionType, string output, string[] inputs)
    {
        public InstructionType InstructionType { get; } = instructionType;
        public string Output { get; } = output;
        public string[] Inputs { get; } = inputs;
    }
}
