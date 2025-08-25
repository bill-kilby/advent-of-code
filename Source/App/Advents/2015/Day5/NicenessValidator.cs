using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day5
{
    public class NicenessValidator : IValidator<string>
    {
        private string _input;

        private HashSet<char> _vowels = new()
        {
            'a','e','i','o','u'
        };

        private HashSet<string> _naughtyStrings = new()
        {
            "ab", "cd", "pq", "xy"
        };

        public bool Validate(string value)
        {
            _input = value;

            return ContainsThreeVowels()
                && ContainsDoubleLetter()
                && !ContainsNaughtyStrings();
        }

        private bool ContainsThreeVowels()
        {
            var count = 0;
            foreach (var character in _input)
            {
                if (_vowels.Contains(character)) count++;
            }

            return count >= 3;
        }

        private bool ContainsDoubleLetter()
        {
            var previousLetter = _input[0];
            for (var i = 1; i < _input.Length; i++)
            {
                var previous = _input[i - 1];
                if (previous == _input[i]) return true;
            }

            return false;
        }

        private bool ContainsNaughtyStrings()
        {
            foreach (var entry in _naughtyStrings)
            {
                if (_input.Contains(entry)) return true;
            }

            return false;
        }
    }
}
