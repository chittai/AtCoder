using System;
using System.Linq;

namespace EDPC
{
    class A
    {
        static void Main(string[] args)
        {
            // input
            long N = long.Parse(Console.ReadLine());
            long[] h = Console.ReadLine().Split().Select(long.Parse).ToArray();

            //DP table
            long[] DP = new long[N].Select(x => x = int.MaxValue).ToArray();

            // Main
            DP[0] = 0;
            DP[1] = Math.Abs(h[1] - h[0]);
            for (long i = 2; i < N; i++)
            {
                for (long j = 1; j <= 2; j++)
                {
                    DP[i] = Math.Min(DP[i], DP[i - j] + Math.Abs(h[i] - h[i - j]));
                }
            }
            Console.WriteLine(DP[N - 1]);
        }
    }
}
