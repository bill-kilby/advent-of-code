using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Abstractions
{
    public interface IFactory<T>
    {
        public T Create(string input);
    }
}
