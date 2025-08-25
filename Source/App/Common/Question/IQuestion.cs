using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Question
{
    internal interface IQuestion<T>
    {
        public Answer<T> Solve(string path);
    }
}
