using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.solve(5);
        }
    }

    class Solution
    {
        public List<List<int>> solve(int A)
        {

            var pascalTriangle = new List<List<int>>();

            for (int row = 0; row < A; row++)
            {
                var array = new List<int>();
                for (int col = 0; col < A; col++)
                {
                    if (col == 0)
                    {
                        array.Add(1);
                    }
                    else
                    {
                        array.Add(0);
                    }
                }
                pascalTriangle.Add(array);
            }

            for (int row = 1; row < A; row++)
            {
                for (int col = 1; col < A; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col] + pascalTriangle[row - 1][col - 1];
                }
            }

            var output = new List<List<int>>();

            for (int row = 0; row < A; row++)
            {
                var array = new List<int>();
                for (int col = 0; col < A; col++)
                {
                    if (pascalTriangle[row][col] != 0)
                    {
                        array.Add(pascalTriangle[row][col]);
                    }
                }
                output.Add(array);
            }

            return output;
        }
    }

}
