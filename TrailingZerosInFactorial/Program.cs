using System;

namespace TrailingZerosInFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.trailingZeroes(5);
        }
    }

    class Solution
    {
        public int trailingZeroes(int A)
        {

            int zeroCount = 0;

            int divisor = 5;

            while (divisor <= A)
            {

                zeroCount += A / divisor;
                divisor *= 5;
            }

            return zeroCount;

        }
    }

}
