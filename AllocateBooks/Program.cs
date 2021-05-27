using System;
using System.Collections.Generic;
using System.Linq;

namespace AllocateBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.books(new List<int>() { 12, 34, 67, 90 }, 2);
        }
    }

    class Solution
    {
        public int books(List<int> A, int B)
        {

            if (B > A.Count)
            {
                return -1;
            }

            var max = A.Max();
            var sum = A.Sum();

            if (B == A.Count)
            {
                return max;
            }
            if (B == 1)
            {
                return sum;
            }

            var high = sum;
            var low = max;
            var mid = -1;

            while (low <= high)
            {

                mid = (low + high) / 2;

                var student = 1;
                var sumOfPages = 0;
                foreach (var pageCount in A)
                {
                    sumOfPages += pageCount;
                    if (sumOfPages > mid)
                    {
                        student++;
                        sumOfPages = pageCount;
                    }
                }

                if (student <= B)
                {
                    high = mid - 1;
                }
                else
                {
                    low = low + 1;
                }
            }
            return low;
        }
    }

}
