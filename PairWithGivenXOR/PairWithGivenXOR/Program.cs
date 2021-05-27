using System;
using System.Collections.Generic;

namespace PairWithGivenXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            sol.solve(new List<int>() { 3, 6, 8, 10, 15, 50 }, 5);
        }
    }


    class Solution
    {
        public int solve(List<int> A, int B)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    if ((A[i] ^ A[j]) == B)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

}
