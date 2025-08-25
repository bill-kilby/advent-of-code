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
    public class Question : QuestionBase<int>
    {
        private MD5 hasher = MD5.Create();

        internal override int SolveSilver(string path)
        {
            var input = InputHelper.GetText(path);

            var num = 1;
            var preHash = $"{input}{num}";
            var hash = GetHash(preHash);

            while (!StartsWithExpectedZeroCount(hash, 5))
            {
                num++;
                preHash = $"{input}{num}";
                hash = GetHash(preHash);
            }

            return num;
        }

        internal override int SolveGold(string path)
        {
            return 0;
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

                if (count == 5) return true;
            }

            return false;
        }
    }
}
