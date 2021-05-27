using System;

namespace VeryLargePower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(2, 27);
        }
    }

    class Solution
    {
        public int solve(int A, int B)
        {
            int n = B;
            long fact = B;
            var p = 1000000007;
            while (n != 1)
            {

                fact = (fact*(n-1)) % (p-1);
                n--;
            }

            fact = fact % (p-1);

            if (fact == 1)
            {
                return A;
            }

            var ans = pow(A, fact, p);
            return ans;
        }

        public int pow(long a, long b, int p)
        {
            if (b == 0)
            {
                return 1;
            }
            if (b == 1)
            {
                return 1;
            }

            long result = 1;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    result = ((result%p) * (a%p));
                }
                a = ((a%p) * (a%p))%p;
                b = b / 2;
            }

            return (int)(result%p);
        }
    }

}
