using System;

namespace PalindromeInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.isPalindrome(2147447412);
        }
    }

    class Solution
    {
        public int isPalindrome(int A)
        {
            if (A < 0)
            {
                return 0;
            }

            while (A != 0)
            {
                int n1 = A / 10;
                A = n1;
                int n2 = A % 10;
                if (n1 != n2)
                    return 0;
            }
            return 1;
        }
    }

}
