using System;
using System.Linq;

namespace ABC153
{
    class E
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long H = input[0];
            long N = input[1];

            long[,] DP = new long[N + 10, H + 10];
            long[] A = new long[N];
            long[] B = new long[N];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                A[i] = input[0];
                B[i] = input[1];
            }

            for (int i = 0; i <= N; i++)
            {
                for (int h = 0; h <= H; h++)
                {
                    DP[i, h] = int.MaxValue;
                }
            }

            DP[0, 0] = 0;
            for (int i = 0; i < N; i++)
            {
                for (int h = 0; h <= H; h++)
                {
                    DP[i + 1, h] = Math.Min(DP[i + 1, h], DP[i, h]);
                    DP[i + 1, Math.Min(h + A[i], H)] = Math.Min(DP[i + 1, Math.Min(h + A[i], H)], DP[i + 1, h] + B[i]);
                }
            }
            Console.WriteLine(DP[N, H]);
        }
    }
}
