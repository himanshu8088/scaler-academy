using System;
using System.Collections.Generic;

namespace SpecialInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() { 1,2,3,4,5}, 10);
        }
    }

    class Solution
    {
        public int solve(List<int> A, int B)
        {

            var high = A.Count;
            var low = 0;
            var res = 0;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (isPossible(A, B, mid))
                {
                    low = mid + 1;
                    res = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return res;
        }

        public bool isPossible(List<int> A, int B, int K)
        {
            var i = 0;
            var j = K - 1;

            long sum = 0;
            for (; i <= j; i++)
            {
                sum += A[i];
            }

            if (sum > B)
            {
                return false;
            }

            i=0;
            while (j < A.Count)
            { 
                j++;
                if (j < A.Count)
                {
                    sum -= A[i];
                    sum += A[j];
                    if (sum > B)
                    {
                        return false;
                    }
                }
                i++;
            }

            return true;
        }
    }

}
