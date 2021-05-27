using System;
using System.Collections.Generic;

namespace SingleNumberIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() { 684, 96, 1126, 1288, 330, 1360, 940, 330, 1288, 580, 476, 812, 96, 264, 1360, 684, 476, 1126, 580, 812 });
        }
    }
    class Solution
    {
        public List<int> solve(List<int> A)
        {

            var first = new List<int>();
            var second = new List<int>();

            var allXor = xor(A);
            var n = 0;
            while (true)
            {
                if ((allXor & (1 << n)) != 0)
                {
                    break;
                }

                n++;
            }

            for (int i = 0; i < A.Count; i++)
            {
                if ((A[i] & (1 << n)) != 0)
                {
                    first.Add(A[i]);
                }
                else
                {
                    second.Add(A[i]);
                }
            }

            var result = new List<int>();
            var a = xor(first);
            var b = xor(second);
            if (a < b)
            {
                result.Add(a);
                result.Add(b);
            }
            else
            {
                result.Add(b);
                result.Add(a);
            }
            return result;
        }

        public int xor(List<int> item)
        {
            var ele = item[0];
            for (int i = 1; i < item.Count; i++)
            {
                ele = ele ^ item[i];
            }
            return ele;
        }
    }


}
