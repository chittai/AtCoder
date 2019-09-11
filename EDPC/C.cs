using System;
using System.Linq;

namespace EDPC
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] input = new string[N];
            int[,] score = new int[N, 3];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    score[i, j] = int.Parse(input[j]);
                }
            }


            int[,] dp = new int[N + 10, 3];

            // Main processing
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (j != k) dp[i + 1, k] = Math.Max(dp[i + 1, k], dp[i, j] + score[i, k]);
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                if (max < dp[N, i]) { max = dp[N, i]; }
            }
            Console.WriteLine(max);
        }
    }
}
