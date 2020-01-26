using System;
using System.Linq;

namespace ABC153
{
    class E
    {
        static long H;
        static long N;
        static long[,] DP;
        static long[] A;
        static long[] B;
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            H = input[0];
            N = input[1];

            DP = new long[N + 10, H + 10];
            A = new long[N];
            B = new long[N];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                A[i] = input[0];
                B[i] = input[1];
            }

            /*
            for (int i = 0; i < N + 10; i++)
            {
                for (int j = 0; j < H + 10; j++)
                {
                    DP[i, j] = 0;
                }
            }
            */

            for (int h = 0; h <= H; h++)
            {
                DP[0, h] = 0;
            }

            for (int h = 0; h <= H; h++)
            {
                if (h % A[1] == 0) DP[1, h] = h / A[1] * B[1];
                //else DP[1, h] = h / A[1] * B[1] + B[1];
            }

            for (int i = 1; i < N; i++)
            {
                for (int h = 0; h <= H; h++)
                {
                    if (h >= A[i] * B[i])
                    {
                        DP[i + 1, h] = Math.Min(DP[i, h - H / A[i] * B[i]] + H / A[i] * B[i], DP[i, h]);
                    }
                    else
                    {
                        DP[i + 1, h] = DP[i, h];
                    }
                }
            }

            Console.WriteLine(DP[N, H - 1]);


            for (int i = 0; i < N + 10; i++)
            {
                for (int j = 0; j < H + 10; j++)
                {
                    if (DP[i, j] != 0 && DP[i, j] != int.MaxValue) Console.WriteLine(DP[i, j]);
                }
            }

        }
    }
}
