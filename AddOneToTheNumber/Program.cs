using System;
using System.Collections.Generic;

namespace AddOneToTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.plusOne(new List<int>() { 0, 6, 0, 6, 4, 8, 8, 1 });
        }
    }

    class Solution
    {
        public List<int> plusOne(List<int> A)
        {

            if (A.Count > 1)
            {
                while(A[0] == 0)
                {
                   A.RemoveAt(0);
                }
            }

            var digits = reverse(A);

            var carry = 1;
            for (var index = 0; index < digits.Count; index++)
            {
                var sum = digits[index] + carry;
                if (sum >= 10)
                {
                    carry = sum / 10;
                    digits[index] = sum % 10;
                    if (index == digits.Count - 1)
                    {
                        digits.Add(carry);
                        return reverse(digits);
                    }
                }
                else
                {
                    digits[index] = sum;
                    break;
                }
            }

            return reverse(digits);
        }

        public List<int> reverse(List<int> list)
        {
            int n = list.Count;

            for (int i = 0; i < n / 2; i++)
            {
                list[i] = list[i] ^ list[n - i - 1];
                list[n - i - 1] = list[i] ^ list[n - i - 1];
                list[i] = list[i] ^ list[n - i - 1];
            }

            return list;
        }
    }

}
