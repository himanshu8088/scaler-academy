using System;
using System.Collections.Generic;

namespace AntiDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new List<List<int>>()
            {
                new List<int>(){ 1, 2, 3},
                new List<int>(){ 4, 5, 6},
                new List<int>(){ 7, 8, 9}
            };

            var antiDiagonalArray = (new Solution()).diagonal(matrix);

        }
    }

    class Solution
    {
        public List<List<int>> diagonal(List<List<int>> A)
        {
            int row = 0;
            int len = A.Count;
            var antiDiagonalArray = new List<List<int>>();
            for (; row< len; row++)
            {
                var array = new List<int>();
                for(int j=0, k=row; j<=row; j++, k--)
                {
                    array.Add(A[j][k]);
                }
                antiDiagonalArray.Add(array);
            }

            for(row=1; row<len; row++)
            {
                var array = new List<int>();
                for (int j = row, k = len-1; j < len; j++, k--)
                {
                    array.Add(A[j][k]);
                }
                antiDiagonalArray.Add(array);
            }

            return antiDiagonalArray;
        }
    }

}
