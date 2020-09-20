using System;
using System.Linq;
using System.Collections.Generic;

namespace KEYENCE2020
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] Odd = new int[N];
            int[] Even = new int[N];
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    Odd[i] = A[i];
                    Even[i] = B[i];
                }
                else
                {
                    Odd[i] = B[i];
                    Even[i] = A[i];
                }
            }

            Console.WriteLine(string.Join(" ", Odd));
            Console.WriteLine(string.Join(" ", Even));

        }
    }
}
