using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Question
{
    public readonly struct Answer<T> (T silver, T gold)
    {
        public T Silver { get; } = silver;
        public T Gold { get; } = gold;
    }
}
