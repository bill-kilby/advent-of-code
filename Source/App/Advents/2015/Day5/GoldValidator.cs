using App.Common.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App.Advents._2015.Day5
{
    public class GoldValidator : IValidator<string>
    {
        private string _input = string.Empty;

        public bool Validate(string value)
        {
            _input = value;

            return HasDoublePair()
                && HasSpacedPair();
        }

        private bool HasDoublePair()
        {
            var regex = new Regex(@"([a-zA-Z]{2}).*?\1");

            if (regex.IsMatch(_input)) return true;
            return false;
        }

        private bool HasSpacedPair()
        {
            var regex = new Regex(@".*([a-zA-Z]).\1.*");

            if (regex.IsMatch(_input)) return true;
            return false;
        }
    }
}
