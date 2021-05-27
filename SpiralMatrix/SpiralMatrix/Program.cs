using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        var matrix = generateMatrix(A);
        for(int i=0; i<matrix.Count; i++)
        {
            for(int j=0; j< matrix.Count; j++)
            {
                Console.WriteLine(matrix[i][j]+" ");
            }
            Console.WriteLine();
        }
    }

    public static List<List<int>> generateMatrix(int A)
    {
        int t = 0;
        int l = 0;
        int r = A - 1;
        int b = A - 1;
        int count = 0;

        var matrix = new List<List<int>>();
        for (int i = 0; i < A; i++)
        {
            matrix.Add(new List<int>());
        }

        while (t <= b && l <= r)
        {
            for (int k = l; k <= r; k++)
            {
                matrix[t].Add(++count);
            }
            t++;

            for (int k = t; k <= b; k++)
            {
                matrix[k][r] = ++count;
            }
            r--;

            for (int k = r; k >= l; k--)
            {
                matrix[b][k] = ++count;
            }
            b--;

            for (int k = b; k >= t; k--)
            {
                matrix[k][l] = ++count;
            }
            l++;
        }

        return matrix;
    }
}
