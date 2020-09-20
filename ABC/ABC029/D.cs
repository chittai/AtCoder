using System;

namespace ABC029
{
    class D
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int[,,] dp = new int[N.Length + 1, N.Length + 1, 2];
            dp[0, 0, 0] = 1;

            for (int i = 0; i < N.Length; i++)
            {
                int nd = N[i] - '0';
                for (int j = 0; j < N.Length; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            int ni = i + 1;
                            int nj = j;
                            int nk = k;

                            if (d == 1) nj++;
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
            int res = 0;
            for (int i = 0; i <= N.Length; i++)
            {
                res += (dp[N.Length, i, 0] + dp[N.Length, i, 1]) * i;
            }
            Console.WriteLine(res);
        }
    }
}
