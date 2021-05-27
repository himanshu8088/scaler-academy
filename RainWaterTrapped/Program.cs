using System;
using System.Collections.Generic;

namespace RainWaterTrapped
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.trap(new List<int>() { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        }
    }

    class Solution
    {
        public int trap(List<int> A)
        {
            var prefix = new List<int>();
            var suffix = new List<int>();

            var prefixMax = Int32.MinValue;
            var suffixMax = Int32.MinValue;

            if (A.Count <= 2)
                return 0;

            for (int index = 0; index < A.Count; index++)
            {
                if (prefixMax < A[index])
                {
                    prefixMax = A[index];
                }
                prefix.Add(prefixMax);

                var n = A.Count - index - 1;
                if (suffixMax < A[n])
                {
                    suffixMax = A[n];
                }
                suffix.Add(suffixMax);

            }

            var trap = 0;

            for (int index = 1; index < A.Count-1; index++)
            {
                trap += Math.Min(prefix[index - 1], suffix[index + 1]) - A[index];
            }
            return trap;
        }
    }

}
