using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfAAndBShouldBeEqualToCAndD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sol = new Solution();
            var output = sol.equal(new List<int>() { 9, 5, 4, 9, 3, 6, 8, 7, 1, 2, 8, 7, 2, 9, 7, 1, 3, 9, 7, 8, 1, 0, 5, 5 });
           // var output = sol.equal(new List<int>() { 1, 3, 3, 3, 3, 2, 2 });
            //  var output = sol.equal(new List<int>() { 1, 1, 1, 1, 1 });
            //var output = sol.equal(new List<int>() { 3, 4, 7, 1, 2, 9, 8 });
        }
    }

    class Solution
    {
        public List<int> equal(List<int> A)
        {
            var map = new Dictionary<int, List<int>>();
            var output = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    var temp = new List<int>();
                    var sum = A[i] + A[j];
                    if (map.ContainsKey(sum))
                    {
                        var m = map[sum][0];
                        var n = map[sum][1];
                        if (n != i && m != i && n != j && m != j)
                        {
                            temp.AddRange(map[sum]);
                            temp.AddRange(new List<int>() { i, j });
                            output = getLexicographicallySmallerArray(output, temp);
                        }
                    }
                    else
                    {
                        map.Add(sum, new List<int>() { i, j });
                    }
                }
            }
            return output;
        }

        public List<int> getLexicographicallySmallerArray(List<int> first, List<int> second)
        {
            if (first.Count == 0)
                return second;

            var a = first.ToArray();
            var b = second.ToArray();
            var data = new int[][]
            {
                a, b
            };
            Comparer<int> comparer = Comparer<int>.Default;
            Array.Sort(data, (x, y) => comparer.Compare(x[1], y[1]));
            return data[0].ToList();
        }

        public int countDigit(long n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                ++count;
            }
            return count;
        }
    }

}
