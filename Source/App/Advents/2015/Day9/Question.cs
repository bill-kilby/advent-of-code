using App.Common.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day9
{
    public class Question : QuestionBase<int>
    {
        /*
         * Map source destinations to destinations
         * Get all cities
         * Permutate cities for all possible routes (k-permutation, we want ABCD as well as AD).
         * Calculate cost for all of these
         * Chuck into a priority queue
         * Get first for silver.
         */

        protected override int SolveSilver(string path)
        {
            return 0;
        }

        protected override int SolveGold(string path)
        {
            return 0;
        }
    }
}
