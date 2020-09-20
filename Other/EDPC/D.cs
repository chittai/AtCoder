using System;
using System.Linq;

namespace EDPC
{
    class D
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            long[,] wv = new long[N, 2];
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split(' ');
                wv[i, 0] = long.Parse(input[0]);
                wv[i, 1] = long.Parse(input[1]);
            }

            long[,] dp = new long[N + 10, W + 10];
            for (int i = 0; i <= W; i++)
            {
                dp[0, i] = 0;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (0 <= j - wv[i, 0])
                    {
                        dp[i + 1, j] = Math.Max(dp[i, j], dp[i, j - wv[i, 0]] + wv[i, 1]);
                    }
                    else
                    {
                        dp[i + 1, j] = dp[i, j];
                    }
                }
            }

            Console.WriteLine(dp[N, W]);

        }
    }
}
