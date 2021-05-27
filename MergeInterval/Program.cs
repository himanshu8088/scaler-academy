using System;
using System.Collections.Generic;

namespace MergeInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<List<int>>() { new List<int>() { 3, 6 }, new List<int>() { 8, 10 } }, 1, 2);
        }

    }

    public class Solution
    {
        public List<List<int>> solve(List<List<int>> A, int B, int C)
        {
            if (B > C)
            {
                var temp = B;
                B = C;
                C = temp;
            }
            var min = Int32.MaxValue;
            var max = Int32.MinValue;
            var mergeAll = false;

            var result = new List<List<int>>();
            foreach (var item in A)
            {
                int currentMin = Int32.MaxValue;
                int currentMax = Int32.MinValue;

                var X = item[0];
                var Y = item[1];
                bool hasOverlapping = ((B >= X && B <= Y) && (C >= X && C <= Y)) ||
                                      ((B >= X && B <= Y) && (C >= X && C >= Y)) ||
                                      ((B <= X && B <= Y) && (C >= X && C <= Y));

                if((B <= X && B <= Y) && (C >= X && C >= Y))
                {
                    mergeAll = true;
                }
                else
                {
                    mergeAll = false;
                }

                if (hasOverlapping)
                {
                    currentMin = Math.Min(item[0], B);
                    currentMax = Math.Max(item[1], C);

                    min = Math.Min(currentMin, min);
                    max = Math.Max(currentMax, max);
                }
                else
                {
                    result.Add(item);
                }
            }

            if (mergeAll)
            {
                return new List<List<int>>() { new List<int>() { B, C } };
            }

            if (min == Int32.MaxValue && max == Int32.MinValue)
            {
                min = B;
                max = C;
            }

            var insertAt = -1;
            for (int index = 0; index < result.Count; index++)
            {
                var X = result[index][0];
                var Y = result[index][1];
                if (B<X && B<Y && C<X && C < Y)
                {
                    insertAt = index;
                    break;
                }
            }
            if (insertAt == -1)
            {
                insertAt = result.Count;
            }
            result.Insert(insertAt, new List<int>() { min, max });

            return result;
        }
    }
}
