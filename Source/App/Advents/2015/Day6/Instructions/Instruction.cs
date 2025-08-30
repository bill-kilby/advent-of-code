using App.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day6.Instructions
{
    public class Instruction(InstructionType instructionType, Vector2Int[] affectedLights)
    {
        public InstructionType InstructionType { get; } = instructionType;
        public Vector2Int[] AffectedLights { get; } = affectedLights;
    }
}
