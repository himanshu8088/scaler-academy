using System;
using System.Collections.Generic;

namespace CountOfDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() { 2, 3, 4, 5 });
        }
    }

    class Solution
    {
        public List<int> solve(List<int> A)
        {

            var sieve = new int[100001];
            int maxLimit = 100000;
            for (int i = 1; i <= maxLimit; i++)
            {
                sieve[i]=i;
            }

            for (int i = 2; i <= maxLimit; i++)
            {
                if (sieve[i] == i)
                {
                    for (int j = i; j <= maxLimit; j += i)
                    {
                        if (sieve[j] == j)
                        {
                            sieve[j] = i;
                        }
                    }
                }
            }

            var result = new List<int>();

            foreach (var item in A)
            {
                var temp = item;
                var ans = 1;

                while (temp != 1)
                {
                    var count = 1;
                    var s = sieve[temp];
                    while (temp != 1 && sieve[temp] % s == 0)
                    {
                        count++;
                        temp = temp / s;
                    }
                    ans *= count;
                }
                result.Add(ans);
            }
            return result;
        }
    }

}
