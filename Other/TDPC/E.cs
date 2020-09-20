using System;
using System.Linq;

namespace TDPC
{
    class E
    {
        static void Main(string[] args)
        {
            long D = long.Parse(Console.ReadLine());
            string N = Console.ReadLine();

            long[,,] dp = new long[N.Length + 10, D, 2];
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
                            int nj = j;
                            int nk = k;

                            if (k == 0)
                            {
                                if (d > nd) continue;
                                if (d < nd) nk = 1;
                            }
                            dp[ni, (j + d) % D, nk] += dp[i, j, k] % 1000000007;
                        }
                    }
                }
            }
            Console.WriteLine((dp[N.Length, 0, 0] + dp[N.Length, 0, 1] - 1) % 1000000007);
        }
    }
}
