using System;
using System.Collections.Generic;

namespace AggressiveCows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() { 82, 61, 38, 88, 12, 7, 6, 12, 48, 8, 31, 90, 35, 5, 88, 2, 66, 19, 5, 96, 84, 95 }, 8);
            //sol.solve(new List<int>() { 1, 2, 3, 4, 5 }, 3);
        }
    }

    class Solution
    {
        public int solve(List<int> A, int B)
        {

            var stalls = A.ToArray();
            Array.Sort(stalls);
            var low = 0;
            var high = stalls[stalls.Length - 1] - stalls[0];
            var ans = 0;
            while (low <= high)
            {
                var mid = (low + high) / 2;
                if (checkIfFits(stalls, mid, B))
                {
                    low = mid + 1;
                    ans = mid;

                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }

        public bool checkIfFits(int[] A, int diff, int B)
        {
            B--;
            var prevValue = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if ((A[i] - prevValue) >= diff)
                {
                    prevValue = A[i];
                    B--;
                    if (B == 0)
                    {
                        return true;
                    }
                }
            }

            if (B == 0)
            {
                return true;
            }
            return false;
        }
    }

}
