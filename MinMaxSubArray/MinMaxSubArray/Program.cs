using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var solution = new Solution();
            var input = new List<int>() { 814, 761, 697, 483, 981 };
            var output = solution.solve(input);
            Console.WriteLine(output);
        }
    }

    class Solution
    {
        public int solve(List<int> A)
        {
            var minValueArray = new List<int>();
            var maxValueArray = new List<int>();

            if (A.Count == 1)
                return 1;
            if(A.Count == 2)
            {
                if (A[0] == A[1])
                    return 1;
                return 2;
            }

            int max = A.Max();
            int min = A.Min();
            
            for(int i=0; i<A.Count; i++)
            {
                if (A[i] == max)
                {
                    maxValueArray.Add(i);
                }
                else if(A[i]==min)
                {
                    minValueArray.Add(i);
                }
            }

            int min_diff=int.MaxValue;
            foreach(var min_index in minValueArray)
            {
                foreach(var max_index in maxValueArray)
                {
                    var difference = diff(max_index, min_index);
                    if (difference < min_diff)
                    {
                        min_diff = difference;
                    }
                }
            }
            if (min_diff == int.MaxValue)
                return 1;
            return min_diff;
        }

        public int diff(int max_index, int min_index)
        {
            if (max_index > min_index)
                return (max_index - min_index) + 1;
            else
                return (min_index - max_index) + 1;
        }
    }
}


