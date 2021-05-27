using System;
using System.Numerics;

namespace AthMagicalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
             //sol.solve(4, 2, 3);
             //sol.solve(14, 10, 12); //ans = 84
             //sol.solve(489039022, 18923, 32309); //ans = 119599631
             sol.solve(807414236, 3788, 38141); //ans = 238134151
        }
    }

    class Solution
    {
        public int solve(int A, int B, int C)
        {
            var l = lcm(B, C);
            BigInteger high = (A * Math.Max(B,C));
            BigInteger low = 1;
            BigInteger res = 0;

            while (low <= high)
            {
                BigInteger mid = low + (high - low) / 2;

                BigInteger count = 0;
                count += mid / B;
                count += mid / C;
                count -= mid / l;

                if (count >= A)
                {
                    high = mid - 1;
                    res = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            var result = (int)(res % 1000000007);
            return result;
        }

        int gcd(int a, int b)
        {
            if (b > a)
            {
                b = b ^ a;
                a = b ^ a;
                b = b ^ a;
            }
            if (b == 0) return a;
            return gcd(b, a % b);

        }
        int lcm(int a, int b)
        {
            return (a * b) / gcd(a, b);
        }
    }
}
