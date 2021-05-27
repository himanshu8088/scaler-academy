using System;
using System.Collections.Generic;

namespace SpecialSubSequenceAG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int solve(string A)
        {
            int count = 0;
            int aCount = 0;
            for(int i=0; i<A.Length; i++)
            {
                if (A[i] == 'A')
                    aCount++;
                if (A[i] == 'G')
                    count += aCount;
            }
            return count;
        }
    }

    class Solution0
    {
        public int solve(string A)
        {

            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'A')
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == 'G')
                        {
                            count = (count + 1) % 1000000007;
                        }
                    }
                }
            }
            return count;
        }


    }

    class Solution1
    {
        public int solve(string A)
        {

            var sequence = new List<int>();

            for (int i = 0; i<A.Length; i++)
            {
                if (A[i] == 'A')
                {
                    sequence.Add(0);
                }
                else if (A[i] == 'G')
                {
                    Increment(sequence);
                }
            }
            return Sum(sequence);
        }

        public int Sum(List<int> array)
        {
            int sum = 0;

            for (int i = 0; i < array.Count; i++)
            {
                sum = (array[i] + sum) % 1000000007;
            }

            return sum;
        }

        public void Increment(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                array[i] = (array[i] + 1) % 1000000007;
            }
        }
    }

}
