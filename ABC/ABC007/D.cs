using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC007
{
    class D
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string A = (long.Parse(input[0]) - 1).ToString();
            string B = input[1];

            Console.WriteLine(Count(B) - Count(A));

        }

        static long Count(string S)
        {
            long[,,] dp = new long[S.Length + 1, 2, 2];
            dp[0, 0, 0] = 1;
            for (int i = 0; i < S.Length; i++)
            {
                int nd = S[i] - '0';
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            int ni = i + 1;
                            int nj = j;
                            int nk = k;

                            if (d == 4 || d == 9) nj = 1;
                            if (k == 0)
                            {
                                if (d > nd) continue;
                                if (d < nd) nk = 1;
                            }
                            dp[ni, nj, nk] += dp[i, j, k];
                        }
                    }
                }
            }
            return (dp[S.Length, 1, 0] + dp[S.Length, 1, 1]);
        }

    }
}
