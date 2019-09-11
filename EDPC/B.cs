using System;
using System.Linq;

namespace EDPC
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            input = Console.ReadLine().Split(' ');

            // initialize
            int[] h = new int[N];
            for (int i = 0; i < N; i++)
            {
                h[i] = int.Parse(input[i]);
            }

            long H = int.MaxValue;
            long[] dp = new long[N];
            for (int i = 0; i < N; i++)
            {
                dp[i] = H;
            }
            //var dp = Enumerable.Repeat(int.MaxValue, N).ToArray();

            // Main processing
            dp[0] = 0;
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    if (j <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - j] + Math.Abs(h[i] - h[i - j]));
                    }
                }
            }
            Console.WriteLine(dp[N - 1]);
        }
    }
}
