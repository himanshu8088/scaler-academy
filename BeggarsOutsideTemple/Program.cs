using System;
using System.Collections.Generic;
using System.Linq;

namespace BeggarsOutsideTemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sol = new Solution();
            var b = new List<List<int>>()
            {
                new List<int>(){ 1, 2, 10 },
                new List<int>(){ 2, 3, 20 },
                new List<int>(){ 2, 5, 25 }
            };
            sol.solve(5,b);
        }
    }

    class Solution
    {
        public List<int> solve(int A, List<List<int>> B)
        {

            var array = new int[A];
            foreach (var item in B)
            {
                array[item[0] - 1] += item[2];
                if (item[1] < A)
                {
                    array[item[1]] += (-1 * item[2]);
                }

            }

            int sum = array[0];
            for (int index = 1; index < A; index++)
            {
                sum += array[index];
                array[index] = sum;
            }

            return array.ToList();
        }
    }

}
