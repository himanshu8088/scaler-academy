using System;
using System.Collections.Generic;

namespace NobleInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sol = new Solution();
            var result= sol.solve(new List<int>() { -4, -2, 0, -1, -6 });
        }
    }
}


class Solution
{
    public int solve(List<int> A)
    {

        var array = A.ToArray();
        Array.Sort(array);

        if (array[array.Length - 1] == 0)
            return 1;

        for (var index = 0; index < A.Count; index++)
        {

            if (array[index] == (A.Count - (index + 1)) && (index + 1) < A.Count)
                return 1;

        }
        return -1;
    }
}

