using System;
using System.Collections.Generic;

namespace FirstMissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.firstMissingPositive(new List<int>() { 1, -1, 14, 3 });
        }
    }

    class Solution
    {
        public int firstMissingPositive(List<int> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > 0 && A[i] <= A.Count)
                {
                    var position = A[i] - 1;
                    if (A[position] != A[i])
                    {
                        var temp = A[i];
                        A[i] = A[position];
                        A[position] = temp;
                    }
                }
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > 0 && (A[i] - 1) != i)
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}
