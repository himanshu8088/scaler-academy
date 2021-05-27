using System;
using System.Collections.Generic;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.majorityElement(new List<int>() { 2, 2, 1, 1, 1 });
        }
    }

    class Solution
    {
        public int majorityElement(List<int> A)
        {

            var map = new Dictionary<int, int>();
            int n = (int)Math.Floor((decimal)(A.Count / 2));

            if (A.Count == 1)
                return A[0];

            foreach (var item in A)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                    if (map[item] == n)
                    {
                        return item;
                    }
                }
                else
                {
                    map.Add(item, 1);
                }
            }

            return -1;
        }
    }

}
