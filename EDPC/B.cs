using System;
using System.Linq;

namespace EDPC
{
    class B
    {
        static void Main(string[] args)
        {
            // input
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long K = input[1];
            long[] h = Console.ReadLine().Split().Select(long.Parse).ToArray();

            //DP table
            long[] DP = new long[N].Select(x => x = int.MaxValue).ToArray();

            // Main
            DP[0] = 0;
            DP[1] = Math.Abs(h[1] - h[0]);
            for (long i = 2; i < N; i++)
            {
                for (long j = 1; j <= K; j++)
                {
                    if (0 <= i - j) DP[i] = Math.Min(DP[i], DP[i - j] + Math.Abs(h[i] - h[i - j]));
                }
            }
            Console.WriteLine(DP[N - 1]);
        }
    }
}
