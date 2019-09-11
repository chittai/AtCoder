using System;
using System.Linq;

namespace EDPC
{
    class E
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            const int MAX_N = 110;
            const int MAX_V = 100100;

            long[,] wv = new long[MAX_N, MAX_V];
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split(' ');
                wv[i, 0] = long.Parse(input[0]);
                wv[i, 1] = long.Parse(input[1]);
            }

            long[,] dp = new long[MAX_N, MAX_V];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < MAX_V; j++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }

            dp[0, 0] = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < MAX_V; j++)
                {
                    if (0 <= j - wv[i, 1])
                    {
                        dp[i + 1, j] = Math.Min(dp[i, j], dp[i, j - wv[i, 1]] + wv[i, 0]);
                    }
                    else
                    {
                        dp[i + 1, j] = Math.Min(dp[i + 1, j], dp[i, j]);
                    }
                }
            }

            long res = 0;

            for (int j = 0; j < MAX_V; j++)
            {
                if (dp[N, j] <= W) res = j;
            }
            Console.WriteLine(res);
        }
    }
}
