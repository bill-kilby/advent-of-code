using App.Common.Input;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App.Advents._2015.Day8
{
    public class Question : QuestionBase<int>
    {
        protected override int SolveSilver(string path)
        {
            var input = InputHelper.GetLines(path);

            var total = 0;
            foreach (var line in input)
            {
                total +=
                    GetCodedLength(line) - GetMemoryLength(line);
            }

            return total;
        }

        protected override int SolveGold(string path)
        {
            var input = InputHelper.GetLines(path);

            var total = 0;
            foreach (var line in input)
            {
                total +=
                    GetEncodedLength(line) - GetCodedLength(line);
            }

            return total;
        }

        private int GetEncodedLength(string input)
        {
            var sb = new StringBuilder();

            foreach(var chr in input)
            {
                switch (chr)
                {
                    case '"':
                        sb.Append("\\\"");
                        break;
                    case '\\':
                        sb.Append("\\\\");
                        break;
                    default:
                        sb.Append(chr); 
                        break;
                }
            }

            return sb.Length + 2;
        }

        private int GetCodedLength(string input) => input.Trim().Length;

        private int GetMemoryLength(string input)
        {
            var escaped = Regex.Unescape(input);
            return escaped.Length - 2;
        }
    }
}
