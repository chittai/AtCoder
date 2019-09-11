using System;

namespace EDPC
{
    class A
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
            long H = 100010;
            long[] dp = new long[N];
            for (int i = 0; i < N; i++)
            {
                dp[i] = H;
            }
            dp[0] = 0;
            dp[1] = Math.Abs(h[1] - h[0]);

            // 貰うDP
            for (int i = 2; i < N; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + Math.Abs(h[i] - h[i - 1]), dp[i - 2] + Math.Abs(h[i] - h[i - 2]));
            }
            Console.WriteLine(dp[N - 1]);
        }

        //static void chmax(ref long a, long b) { if (a < b) { a = b; } }
        //static void chmin(ref long a, long b) { if (a > b) { a = b; } }

    }
}
