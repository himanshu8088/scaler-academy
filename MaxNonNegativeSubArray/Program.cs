using System;
using System.Collections.Generic;

namespace MaxNonNegativeSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.maxset(new List<int>() { 0, 0, -1, 0 });
        }
    }

    class Solution
    {
        public List<int> maxset(List<int> A)
        {
            var maxSumIndices = new List<List<int>>();

            long maxSum = 0;
            var startIndex = 0;
            var endIndex = 0;
            long currentMax = 0;
            var negativeCount = 0;
            var positiveCount = 0;
            var totalNegative = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] < 0)
                {
                    totalNegative++;
                    positiveCount = 0;
                    negativeCount++;
                    if (negativeCount == 1)
                    {
                        endIndex = i - 1;
                        if (currentMax > maxSum)
                        {
                            maxSumIndices.Clear();
                            maxSum = currentMax;
                            maxSumIndices.Add(new List<int>() { startIndex, endIndex });
                        }
                        else if(currentMax == maxSum)
                        {
                            maxSum = currentMax;
                            maxSumIndices.Add(new List<int>() { startIndex, endIndex });
                        }
                        currentMax = 0;
                    }
                }
                else
                {
                    negativeCount = 0;
                    positiveCount++;
                    if (positiveCount == 1)
                    {
                        startIndex = i;
                    }
                    currentMax += A[i];
                }

                if (i == A.Count - 1 && A[i] >= 0)
                {
                    endIndex = i;
                    if (currentMax > maxSum)
                    {
                        maxSumIndices.Clear();
                        maxSum = currentMax;
                    }
                    maxSumIndices.Add(new List<int>() { startIndex, endIndex });
                }
            }

            if (totalNegative==A.Count)
            {
                return new List<int>();
            }

            var result = new List<int>();
            var segmentLength = 0;
            for (int i = 0; i < maxSumIndices.Count; i++)
            {
                var length = maxSumIndices[i][1] - maxSumIndices[i][0];
                if (length > segmentLength)
                {
                    segmentLength = length;
                    startIndex = maxSumIndices[i][0];
                    endIndex = maxSumIndices[i][1];
                }
            }

            if (segmentLength == 0)
            {
                return new List<int>() { A[maxSumIndices[0][0]] };
            }

            for (; startIndex <= endIndex; startIndex++)
            {
                result.Add(A[startIndex]);
            }
            return result;
        }
    }

}
