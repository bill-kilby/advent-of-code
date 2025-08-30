using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Question
{
    public abstract class QuestionBase<T> : IQuestion<T>
    {
        public virtual Answer<T> Solve(string path)
        {
            var silver = SolveSilver(path);
            var gold = SolveGold(path);

            return new Answer<T>(silver, gold);
        }

        protected abstract T SolveSilver(string path);

        protected abstract T SolveGold(string path);
    }
}
