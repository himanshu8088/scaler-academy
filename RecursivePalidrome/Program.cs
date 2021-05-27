using System;

namespace RecursivePalidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sol = new Solution();
            sol.solve("naman");
        }
    }

    class Solution
    {
        public int solve(string A)
        {

            if (isPalindrome(A, 0, A.Length-1)){
                return 1;
            }
            return 0;
        }

        public bool isPalindrome(string A, int start, int end)
        {

            if (A.Length == 1 || start == end || start > end)
            {
                return true;
            }
            
            if (A[start]!=A[end])
            {
                return false;
            }
            start++;
            end--;
            return isPalindrome(A, start, end);
        }
    }

}
