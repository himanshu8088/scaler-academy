using System;
using System.Collections.Generic;

namespace PickFromBothSides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() { -969, -948, 350, 150, -59, 724, 966, 430, 107, -809, -993, 337, 457, -713, 753, -617, -55, -91, -791, 758, -779, -412, -578, -54, 506, 30, -587, 168, -100, -409, -238, 655, 410, -641, 624, -463, 548, -517, 595, -959, 602, -650, -709, -164, 374, 20, -404, -979, 348, 199, 668, -516, -719, -266, -947, 999, -582, 938, -100, 788, -873, -533, 728, -107, -352, -517, 807, -579, -690, -383, -187, 514, -691, 616, -65, 451, -400, 249, -481, 556, -202, -697, -776, 8, 844, -391, -11, -298, 195, -515, 93, -657, -477, 587 }, 81);
        }
    }

    class Solution
    {
        public int solve(List<int> A, int B)
        {

            int max = int.MinValue;

            int sum = A[0];
            for (int index = 1; index < A.Count; index++)
            {
                sum += A[index];
                A[index] = sum;
            }

            for (int i = B; i >= 0; i--)
            {
                int temp = 0;

                if ((B == i))
                {
                    temp = A[i - 1];
                }
                else if (i == 0)
                {
                    temp = A[A.Count - 1] - A[A.Count - B - 1];
                }
                else
                {
                    temp = A[i - 1] + A[A.Count - 1] - A[A.Count - (B - i) - 1];
                }

                max = max <= temp ? temp : max;
            }

            return max;
        }
    }

}
