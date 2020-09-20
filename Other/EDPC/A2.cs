using System;

namespace EDPC
{
    class A2
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            // initialize
            long[] h = new long[N];
            for (int i = 0; i < N; i++)
            {
                h[i] = int.Parse(input[i]);
            }

            // 初期条件
            long[] dp = new long[N];
            for (int i = 0; i < N; i++)
            {
                dp[i] = int.MaxValue;
            }
            dp[0] = 0;

            // 配るDP
            for (int i = 0; i < N - 1; i++)
            {
                dp[i + 1] = Math.Min(dp[i + 1], dp[i] + Math.Abs(h[i + 1] - h[i]));
                if (i < N - 2) dp[i + 2] = Math.Min(dp[i + 2], dp[i] + Math.Abs(h[i + 2] - h[i]));
            }
            Console.WriteLine(dp[N - 1]);
        }
    }
}
