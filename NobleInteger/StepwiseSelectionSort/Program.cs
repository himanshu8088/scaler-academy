using System;
using System.Collections.Generic;

namespace StepwiseSelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve(new List<int>() { 6, 4, 3, 7, 2, 8 });

            var solA = new SolutionA();
            solA.solve(new List<char>() { '?', 'a', '0' });
        }
    }

    class Solution
    {
        public List<int> solve(List<int> A)
        {
            var result = new List<int>();

            for (int i = 0; i < A.Count - 1; i++)
            {
                var temp = A[i];
                var smallestElementIndex = i;
                for (int j = 1 + 1; j < A.Count; j++)
                {
                    if (temp > A[j])
                    {
                        temp = A[j];
                        smallestElementIndex = j;
                    }
                }
                result.Add(smallestElementIndex);
                A[i] = A[i] ^ A[smallestElementIndex];
                A[smallestElementIndex] = A[i] ^ A[smallestElementIndex];
                A[i] = A[i] ^ A[smallestElementIndex];
            }

            return result;
        }
    }

    class SolutionA
    {
        public int solve(List<char> A)
        {

            bool isAlpha = false;
            bool isNumeric = false;

            for (int i = 0; i < A.Count; i++)
            {

                if (((int)A[i] >= 65 && (int)A[i] <= 90)
                   || ((int)A[i] >= 97 && (int)A[i] <= 122))
                {
                    isAlpha = true;
                }
                else if ((int)A[i] >= 48 && (int)A[i] <= 57)
                {
                    isNumeric = true;
                }
                else
                {
                    return 0;
                }
            }

            if (isAlpha && isNumeric)
                return 1;

            return 0;
        }
    }


}
