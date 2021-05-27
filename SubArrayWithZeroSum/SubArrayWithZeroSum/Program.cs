using System;
using System.Collections.Generic;

namespace SubArrayWithZeroSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() {1, 2, 3, 4, 5 });
        }
    }
    class Solution
    {
        public int solve(List<int> A)
        {
            var set = new HashSet<long>();
            long sum = 0;
            for (var i = 0; i < A.Count; i++)
            {
                sum = sum + A[i];
                if (A[i] == 0 || sum == 0)
                    return 1;
                if (set.Contains(sum))
                {
                    return 1;
                }
                set.Add(sum);
            }

            return 0;
        }
    }

}


