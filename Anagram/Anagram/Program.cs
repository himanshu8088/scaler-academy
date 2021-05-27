using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            var input1 = new List<string>() { "cat", "dog", "god", "tca" };
            var input2 = new List<string>() { "rat", "tar", "art"};



            var output = sol.anagrams(input1);

            foreach(var item in output)
            {
                foreach(var i in item)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }

        }
    }

    class Solution
    {
        public List<List<int>> anagrams(List<string> A)
        {
            var itemIndexes = new Dictionary<string, List<int>>();

            for (int index = 0; index < A.Count; index++)
            {
                if (itemIndexes.ContainsKey(sort(A[index])))
                {
                    itemIndexes[sort(A[index])].Add(index + 1);
                }
                else
                {
                    itemIndexes.Add(sort(A[index]), new List<int>() { index + 1 });
                }
            }

            var output = new List<List<int>>();
            foreach (var itemIndex in itemIndexes)
            {
                output.Add(itemIndex.Value);
            }
            return output;
        }

        public string sort(string str)
        {
            return String.Concat(str.OrderBy(c => c));
        }
    }
}
