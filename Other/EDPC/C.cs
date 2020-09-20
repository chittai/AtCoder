using System;
using System.Linq;

namespace EDPC
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            int[] b = new int[N];
            int[] c = new int[N];
            int[,] DP = new int[N, 3];

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            DP[0, 0] = input[0];
            DP[0, 1] = input[1];
            DP[0, 2] = input[2];

            for (int i = 1; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (j != k) DP[i, j] = Math.Max(DP[i, j], input[j] + DP[i - 1, k]);
                    }
                }
            }
            Console.WriteLine(Math.Max(DP[N - 1, 2], Math.Max(DP[N - 1, 0], DP[N - 1, 1])));
        }
    }
}
