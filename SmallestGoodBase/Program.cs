using System;
using System.Linq;

namespace SmallestGoodBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sol = new Solution();
            sol.solve("13");
        }
    }

    class Solution
    {
        public string solve(string A)
        {
            ulong num = ulong.Parse(A);
            ulong res = 0;
            for (int x = 60; x >= 2; x--)
            {
                var start = 2uL;
                var end = num;
                while (start <= end)
                {
                    var baseAsMid = start + (end - start) / 2;
                    var lhs = num * (baseAsMid - 1);
                    var rhs = Power(baseAsMid, x) - 1;
                    if (lhs == rhs)
                    {
                        res = baseAsMid;
                        break;
                    }
                    else if (lhs > rhs)
                    {
                        start = baseAsMid + 1;
                    }
                    else
                    {
                        end = baseAsMid - 1;
                    }
                }
                if (res != 0)
                {
                    break;
                }
            }

            if (res != 0)
            {
                return res + "";
            }
            return (num - 1) + "";
        }

        public ulong Power(ulong num, int x)
        {
            ulong res = 1;
            while (x >= 1)
            {
                if (x % 2 == 1)
                {
                    res = res * num;
                }
                num = num * num;
                x = x / 2;
            }
            return res;
        }
    }
}
