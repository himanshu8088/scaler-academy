using System;
using System.Collections.Generic;

namespace MaxSumContiguosSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.maxSubArray(new List<int>() { -89, -277, -475, -480, -420 });
        }
    }

    class Solution
    {
        public int maxSubArray(List<int> A)
        {

            if (A.Count == 1)
            {
                return A[0];
            }

            var sum = A[0];
            var max = sum;
            for (int index = 1; index < A.Count; index++)
            {
                sum += A[index];
                A[index] = sum;
                if (sum > max)
                {
                    max = sum;
                }
            }

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var currentSum = A[i] - A[j];
                    if (currentSum > max)
                    {
                        max = currentSum;
                    }
                }
            }
            return max;
        }
    }

}
