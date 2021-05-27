using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "cat".ToCharArray();
            var b = "tca".ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            Console.WriteLine(a);
            Console.WriteLine(b);


            var solution = new Solution();
            var A = new List<int>() { 1, 2, 2, 1 };
            var B = new List<int>() { 2, 3, 1, 2 };
            var output =solution.solve(A, B);
        }
    }
    class Solution
    {
        public List<int> solve(List<int> A, List<int> B)
        {
            var valueCountMapA = new Dictionary<int, int>();
            var valueCountMapB = new Dictionary<int, int>();
        
            foreach(var a in A)
            {
                if (valueCountMapA.ContainsKey(a))
                {
                    valueCountMapA[a] = valueCountMapA[a] + 1;
                }
                else
                {
                    valueCountMapA.Add(a, 1);
                }
            }
        
            foreach(var b in B)
            {
                if (valueCountMapB.ContainsKey(b))
                {
                    valueCountMapB[b] = valueCountMapB[b] + 1;
                }
                else
                {
                    valueCountMapB.Add(b, 1);
                }
            }

            if (valueCountMapA.Count < valueCountMapB.Count)
            {
                return solve(valueCountMapA, valueCountMapB);
            }
            else
            {
                return solve(valueCountMapB, valueCountMapA);
            }
        }

        public List<int> solve(Dictionary<int, int> smallMap, Dictionary<int, int> largeMap)
        {
            var output = new List<int>();
            foreach(var i in smallMap)
            {
                if (largeMap.ContainsKey(i.Key))
                {
                    var count = largeMap[i.Key] - smallMap[i.Key] >0 ? smallMap[i.Key] : largeMap[i.Key];
                    var values = getItem(count, i.Key);
                    output.AddRange(values);
                }
            }
            return output;
        }

        public List<int> getItem(int count, int item)
        {
            var items = new List<int>();
            while (count > 0)
            {
                items.Add(item);
                count--;
            }
            return items;
        }
    }

}



