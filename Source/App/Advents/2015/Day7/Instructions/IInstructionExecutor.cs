using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day7.Instructions
{
    public interface IInstructionExecutor
    {
        public void Execute(Instruction instruction, Dictionary<string, int> valueMap);
    }
}
