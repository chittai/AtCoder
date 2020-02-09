using System;
using System.Linq;

namespace EDPC
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            int[] h = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] DP = new int[N].Select(x => x = int.MaxValue).ToArray();

            DP[0] = 0;
            DP[1] = Math.Abs(h[1] - h[0]);

            for (int i = 2; i < N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    if (j <= i) DP[i] = Math.Min(DP[i], DP[i - j] + Math.Abs(h[i] - h[i - j]));
                }
            }
            Console.WriteLine(DP[N - 1]);
        }
    }
}
