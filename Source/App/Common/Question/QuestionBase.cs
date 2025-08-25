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
            var gold = SolveSilver(path);

            return new Answer<T>(silver, gold);
        }

        internal abstract T SolveSilver(string path);

        internal abstract T SolverGold(string path);
    }
}
