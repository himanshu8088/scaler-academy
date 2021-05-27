using System;

namespace TitleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            sol.titleToNumber("AB");
        }
    }

    class Solution
    {
        public int titleToNumber(string A)
        {

            var n = A.Length - 1;
            var i = 0;
            var titleNumber = 0;
            while (i <= n)
            {
                titleNumber = titleNumber + ((A[i] - 64) * (int)Math.Pow(26, n - i));
                i++;
            }
            return titleNumber;
        }
    }

}
