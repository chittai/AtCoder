using System;
using System.Linq;

namespace ABC129
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            long[] a = new long[M];
            for (int i = 0; i < M; i++)
            {
                a[i] = long.Parse(Console.ReadLine());
            }

            long[] dp = new long[N + 10];
            dp[N] = 1;

            int index = M - 1;
            for (int i = N - 1; 0 <= i; i--)
            {
                if (0 <= index && a[index] == i) { dp[index] = 0; index--; continue; }
                dp[i] = (dp[i + 1] + dp[i + 2]) % 1000000007;
            }
            Console.WriteLine(dp[0]);
        }
    }
}