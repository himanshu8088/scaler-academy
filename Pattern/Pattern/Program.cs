using System;
using System.Collections.Generic;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.solve(2);
        }
    }

    class Solution
    {
        public List<List<int>> solve(int A)
        {

            var pattern = new List<List<int>>();

            for (int i = 0; i < A; i++)
            {
                var array = new List<int>();
                for (int j = 0; j < A; j++)
                {
                    array.Add(0);
                }
                pattern.Add(array);
            }

            for (int i = 0; i < A; i++)
            {
                for (int j = A - 1, k = 1; k <= i + 1; j--, k++)
                {
                    pattern[i][j] = k;
                }
            }

            return pattern;

        }
    }

}
