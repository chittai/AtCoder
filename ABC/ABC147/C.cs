using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC147
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[,] x = new int[20, 20];
            int[,] y = new int[20, 20];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                for (int j = 0; j < A[i]; j++)
                {
                    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    x[i, j] = input[0];
                    y[i, j] = input[1];
                }
            }

            int res = 0;
            for (int bit = 0; bit < (1 << N); bit++)
            {
                int count = 0;
                bool ok = true;
                for (int i = 0; i < N; i++)
                {
                    if ((bit & (1 << i)) <= 0) continue;
                    count++;
                    for (int j = 0; j < A[i]; j++)
                    {
                        if ((bit & (1 << (x[i, j] - 1))) > 0)
                        {
                            if (y[i, j] == 0) ok = false;
                        }
                        else
                        {
                            if (y[i, j] == 1) ok = false;
                        }
                    }
                }
                if (ok) { res = Math.Max(res, count); }

            }

            Console.WriteLine(res);

        }
    }
}