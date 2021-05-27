using System;

namespace ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(3);
        }
    }

    class Solution
    {
        public long solve(long A)
        {

            var bitCount = 31;
            int i = 0;
            long result = 0;
            while (bitCount >= 0)
            {
                if ((A & (1 << i)) != 0){
                    result = result + (1 << bitCount);
                }
                i++;
                bitCount--;
            }
            return result;
        }
    }
}


