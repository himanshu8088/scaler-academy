using System;
using System.Collections.Generic;

namespace AtLeast2GreaterElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sol = new Solution();
            sol.solve(new List<int>() { 5, 17, 100, 11 });
        }
    }

    class Solution
    {
        public List<int> solve(List<int> A)
        {

            var array = A.ToArray();
            Array.Sort(array);
            var set = new HashSet<int>();
            var n = array.Length;

            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] < array[n - 1] && array[i] < array[n - 2])
                {
                    set.Add(array[i]);
                }
            }

            var result = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (set.Contains(A[i]))
                {
                    result.Add(A[i]);
                }
            }

            return result;
        }
    }

}


