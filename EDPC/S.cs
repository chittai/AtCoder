using System;
using System.Linq;

namespace EDPC
{
    class S
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int D = int.Parse(Console.ReadLine());
            int mod = 1000000007;

            long[,,] dp = new long[N.Length + 1, D, 2];
            dp[0, 0, 0] = 1;

            for (int i = 0; i < N.Length; i++)
            {
                int nd = N[i] - '0';
                for (int j = 0; j < D; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            int ni = i + 1;
                            int nj = (j + d) % D;
                            int nk = k;

                            if (k == 0)
                            {
                                if (d > nd) continue;
                                if (d < nd) nk = 1;
                            }
                            dp[ni, nj, nk] += dp[i, j, k] % mod;
                        }
                    }
                }
            }
            Console.WriteLine((dp[N.Length, 0, 0] + dp[N.Length, 0, 1] - 1) % mod);
        }
    }
}
