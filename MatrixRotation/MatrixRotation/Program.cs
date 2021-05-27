using System;
using System.Collections.Generic;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var a = new List<List<int>>()
            {
                new List<int>(){ 1, 2 },
                new List<int>(){ 3, 4 }
            };
            solution.rotate(a);
        }
    }

    class Solution
    {
        public void rotate(List<List<int>> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    a[i][j] = a[i][j] ^ a[j][i];
                    a[j][i] = a[i][j] ^ a[j][i];
                    a[i][j] = a[i][j] ^ a[j][i];
                }
            }

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count / 2; j++)
                {
                    a[i][j] = a[i][j] ^ a[i][a.Count - j - 1];
                    a[i][a.Count - j - 1] = a[i][j] ^ a[i][a.Count - j - 1];
                    a[i][j] = a[i][j] ^ a[i][a.Count - j - 1];
                }
            }

        }

    }
}
