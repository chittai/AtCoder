using System;
using System.Linq;

namespace ABC154
{
    class E
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());

            int[,,] dp = new int[105, 4, 2];
            dp[0, 0, 0] = 1;

            for (int i = 0; i < N.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        int nd = N[i] - '0';
                        for (int d = 0; d < 10; d++)
                        {
                            int ni = i + 1;
                            int nj = j;
                            int nk = k;
                            if (d != 0) nj++;
                            if (nj > K) continue;
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
            Console.WriteLine(dp[N.Length, K, 0] + dp[N.Length, K, 1]);
        }
    }
}
