using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var A = new List<int>() { 2, 7, 11, 15 };
            var B = 9;
            var output = Solution.twoSum(A, B);
        }
    }

    class Solution
    {
        public static List<int> twoSum(List<int> A, int B)
        {

            var output = new List<int>();
            int index1 = int.MaxValue;
            int index2 = int.MaxValue;
            bool found = false;
            var set = new HashSet<int>();

            for (int i = 0; i < A.Count; i++)
            {

                if (set.Contains(B - A[i]))
                {
                    if (i < index2)
                    {
                        index2 = i;
                        index1 = A.IndexOf(B - A[i]);
                        found = true;
                    }
                }
                set.Add(A[i]);
            }

            if (found)
            {
                output.Add(index1 + 1);
                output.Add(index2 + 1);
            }

            return output;
        }
    }
}
