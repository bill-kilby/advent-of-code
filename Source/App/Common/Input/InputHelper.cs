using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Input
{
    internal static class InputHelper
    {
        private static readonly string InputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Inputs");

        /// <summary>
        /// Returns the input as a single string.
        /// </summary>
        internal static string GetText(string path)
        {
            var inputPath = Path.Combine(InputPath, path);
            return File.ReadAllText(inputPath);
        }

        /// <summary>
        /// Returns the input as a list of lines.
        /// </summary>
        internal static string[] GetLines(string path)
        {
            var inputPath = Path.Combine(InputPath, path);
            return File.ReadLines(inputPath).ToArray();
        }
    }
}
