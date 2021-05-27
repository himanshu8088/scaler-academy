using System;

namespace NthMagicNumber
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
        public int solve(int A)
        {

            int magicNumber = 0;
            int n = 1;

            while (A > 0)
            {

                if ((A & 1) == 1)
                {
                    magicNumber += (int)Math.Pow(5, n);
                }
                A = A >> 1;
                n++;
            }

            return magicNumber;
        }
    }

}
