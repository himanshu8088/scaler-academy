using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxLengthOfConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            var output = sol.solve("111001");
        }
    }

    class Solution
    {
        public int solve(string A)
        {

            int totalOneCount = 0;
            var positionOfZero = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '1')
                {
                    totalOneCount++;
                }
                else
                {
                    positionOfZero.Add(i);
                }
            }

            if (positionOfZero.Count == 0)
            {
                return totalOneCount;
            }

            int max = 0;
            foreach (var i in positionOfZero)
            {
                int left = 0;
                int right = 0;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (A[k] == '1')
                    {
                        left++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int k = i + 1; k < A.Length; k++)
                {
                    if (A[k] == '1')
                    {
                        right++;
                    }
                    else
                    {
                        break;
                    }
                }
                int temp = GetLengthOfConsecutiveOnes(left, right, totalOneCount);
                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }

        public int GetLengthOfConsecutiveOnes(int left, int right, int totalOne)
        {
            if (left + right < totalOne)
            {
                return left + right + 1;
            }
            else
            {
                return left + right;
            }

        }
    }
}
