using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Exceptions
{
    internal class InvalidCharacterException(char? character) : Exception($"Invalid character found: '{character}'.")
    {
    }
}
