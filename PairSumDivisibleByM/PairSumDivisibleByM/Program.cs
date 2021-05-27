using System;
using System.Collections.Generic;

namespace PairSumDivisibleByM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() { 5, 17, 100, 11 }, 28);
        }
    }

    class Solution
    {
        public int solve(List<int> A, int B)
        {

            for (int i = 0; i < A.Count; i++)
            {
                A[i] %= B;
            }
            int count = 0;
            var map = new Dictionary<int, int>();
            foreach(int item in A)
            {
                if (map.ContainsKey(B - item))
                {
                    count = (count % 1000000007 + map[B - item] % 1000000007) % 1000000007;
                }

                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item] = (map[item] +1) % 1000000007;
                }
            }

            if(map.ContainsKey(0) && map[0] > 1)
            {
                count = (count + (map[0] * (map[0] - 1)) / 2) % 1000000007;
            }

            return count;
        }
    }

}
