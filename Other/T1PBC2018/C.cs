using System;
using System.Linq;

namespace T1PBC2018
{
    class C
    {
        static void Main(string[] args)
        {
            //input, N, A
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            //Aを降順でソートする
            A = A.OrderByDescending(x => x).ToArray();

            if (N % 2 == 0)
            {
                long res = 0;
                for (int i = 0; i < N / 2 - 1; i++)
                {
                    res += A[i] * 2;
                }
                res += A[N / 2 - 1] * 1;
                res += A[N / 2] * -1;
                for (int i = N / 2 + 1; i < N; i++)
                {
                    res += A[i] * -2;
                }
                Console.WriteLine(res);
            }
            else
            {
                long res1 = 0;
                long res2 = 0;
                for (int i = 0; i < N / 2 - 1; i++)
                {
                    res1 += A[i] * 2;
                }
                res1 += A[N / 2 - 1] * 1;
                res1 += A[N / 2] * 1;
                for (int i = N / 2 + 1; i < N; i++)
                {
                    res1 += A[i] * -2;
                }

                for (int i = 0; i < N / 2; i++)
                {
                    res2 += A[i] * 2;
                }
                res2 += A[N / 2] * -1;
                res2 += A[N / 2 + 1] * -1;
                for (int i = N / 2 + 2; i < N; i++)
                {
                    res2 += A[i] * -2;
                }

                Console.WriteLine(Math.Max(res1, res2));

            }

        }
    }
}