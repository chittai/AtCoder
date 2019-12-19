using System;
using System.Linq;

namespace EDPC
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // DP table
            int[,] DP = new int[N, 3];
            int[] a = new int[N];
            int[] b = new int[N];
            int[] c = new int[N];

            // init DP table
            // init value
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < 3; i++)
            {
                DP[0, i] = input[i];
            }

            // Main
            for (int i = 1; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (j != k) DP[i, j] = Math.Max(DP[i, j], DP[i - 1, k] + input[j]);
                    }
                }
            }
            Console.WriteLine(Math.Max(Math.Max(DP[N - 1, 0], DP[N - 1, 1]), DP[N - 1, 2]));
        }
    }
}
