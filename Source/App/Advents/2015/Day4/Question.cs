using App.Common.Input;
using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day4
{
    /// <summary>
    /// https://adventofcode.com/2015/day/4
    /// </summary>
    public class Question : QuestionBase<int>
    {
        private MD5 hasher = MD5.Create();

        protected override int SolveSilver(string path)
        {
            var input = InputHelper.GetText(path);

            return Solve(input, 5);
        }

        protected override int SolveGold(string path)
        {
            var input = InputHelper.GetText(path);

            return Solve(input, 6);
        }

        private int Solve(string input, int expected)
        {
            var num = 1;
            var preHash = $"{input}{num}";
            var hash = GetHash(preHash);

            while (!StartsWithExpectedZeroCount(hash, expected))
            {
                num++;
                preHash = $"{input}{num}";
                hash = GetHash(preHash);
            }

            return num;
        }

        private string GetHash(string input)
        {
            var hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        private bool StartsWithExpectedZeroCount(string hash, int expected)
        {
            var count = 0;

            foreach (var entry in hash)
            {
                if (entry == '0') count++;
                else break;

                if (count == expected) return true;
            }

            return false;
        }
    }
}
