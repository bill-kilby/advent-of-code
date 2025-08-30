using App.Advents._2015.Day7.Instructions;
using App.Common.Abstractions;
using App.Common.Input;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day7
{
    /// <summary>
    /// https://adventofcode.com/2015/day/7
    /// </summary>
    public class Question : QuestionBase<int>
    {
        private IFactory<Instruction, string> _instructionFactory = new InstructionFactory();
        private IFactory<Dictionary<string, ushort?>, Instruction[]> _mapFactory = new ValueMapFactory();
        private IInstructionExecutor _executor = new InstructionExecutor();

        protected override int SolveSilver(string path)
        {
            var input = InputHelper.GetLines(path);

            var instructions = GetInstructions(input);
            var map = _mapFactory.Create(instructions);

            Solve(map, instructions);

            return (int) map["a"]!;
        }

        protected override int SolveGold(string path)
        {
            var input = InputHelper.GetLines(path);

            var instructions = GetInstructions(input);
            var map = _mapFactory.Create(instructions);
            Solve(map, instructions);

            var aValue = map["a"];
            instructions = GetInstructions(input);
            map = _mapFactory.Create(instructions);
            map["b"] = aValue;

            Solve(map, instructions);

            return (int) map["a"]!;
        }

        private void Solve(Dictionary<string, ushort?> map, Instruction[] instructions)
        {
            var queue = CreateQueue(instructions);

            while (true)
            {
                Tick(map, queue);

                if (Solved(map)) break;
            }
        }

        private Queue<Instruction> CreateQueue(Instruction[] instructions)
        {
            var queue = new Queue<Instruction>();

            foreach (var instruction in instructions)
            {
                queue.Enqueue(instruction);
            }

            return queue;
        }

        private void Tick(Dictionary<string, ushort?> map, Queue<Instruction> queue)
        {
            var instruction = queue.Dequeue();

            _executor.Execute(instruction, map);

            if (!instruction.Complete) queue.Enqueue(instruction);
        }

        private bool Solved(Dictionary<string, ushort?> map)
        {
            if (map["a"] != null) return true;
            return false;
        }

        private Instruction[] GetInstructions(string[] input)
        {
            var instructions = new List<Instruction>();

            foreach (var line in input)
            {
                instructions.Add(
                    _instructionFactory.Create(line));
            }

            return instructions.ToArray();
        }
    }
}
