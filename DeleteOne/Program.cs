using System;
using System.Collections.Generic;

namespace DeleteOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sol = new Solution();
            sol.solve(new List<int>() { 12, 15, 18 });
        }
    }
    class Solution
    {
        public int solve(List<int> A)
        {
            if (A.Count == 1)
            {
                return 1;
            }

            if(A.Count == 2)
            {
                return Math.Max(A[0], A[1]);
            }

            if (A.Count == 3)
            {
                var a = gcd(A[0], A[1]);
                var b = gcd(A[1], A[2]);
                var c = gcd(A[0], A[2]);

                var max = Math.Max(a, b);
                return Math.Max(max, c);
            }

            var left = gcdOfItems(A);
            var B = new List<int>(A);
            B.Reverse();
            var right = gcdOfItems(B);
            right.Reverse();

            var maxGcd = int.MinValue;
            for (int index = 0; index < A.Count; index++)
            {

                int currentGcd;
                if (index - 2 >= 0 && index + 1 <= right.Count - 1)
                {
                    currentGcd = gcd(left[index - 2], right[index + 1]);
                }
                else if (index + 1 > right.Count - 1)
                {
                    currentGcd = left[index - 2];
                }
                else
                {
                    currentGcd = right[index + 1];
                }

                maxGcd = Math.Max(currentGcd, maxGcd);
            }

            return maxGcd;
        }


        public int gcd(int A, int B)
        {
            if (B > A)
            {
                A = A ^ B;
                B = A ^ B;
                A = A ^ B;
            }

            while (B != 0)
            {
                var temp = B;
                B = A % B;
                A = temp;
            }
            return A;
        }

        public List<int> gcdOfItems(List<int> A)
        {
            var left = new List<int>();

            left.Add(gcd(A[0], A[1]));
            for (int index = 2; index < A.Count; index++)
            {
                left.Add(gcd(left[index - 2], A[index]));
            }
            return left;
        }

    }

}
