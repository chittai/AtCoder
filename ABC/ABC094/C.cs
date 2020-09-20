using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC094
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] X = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedX = X.OrderBy(x => x).ToArray();

            int res = 0;
            int B1 = sortedX[N / 2 - 1];
            int B2 = sortedX[N / 2];
            for (int i = 0; i < N; i++)
            {
                if (X[i] <= B1) res = B2;
                else res = B1;
                Console.WriteLine(res);
            }
        }
    }
}
