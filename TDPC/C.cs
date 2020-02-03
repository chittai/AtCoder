using System;
using System.Linq;

namespace TDPC
{
    class C
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int X = (int)Math.Pow(2, K);

            double[] R = new double[(int)Math.Pow(2, K)];
            for (int i = 0; i < X; i++)
            {
                R[i] = double.Parse(Console.ReadLine());
            }

            double[,] P = new double[X, X];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    P[i, j] = 1.0 / (1.0 + Math.Pow(10, (R[i] - R[j]) / 400.0));
                }
            }

            double[,] DP = new double[X + 10, K + 10];
            for (int i = 0; i < X; i++)
            {
                DP[i, 0] = 1.0;
            }

            for (int k = 0; k <= K; k++)
            {
                for (int x = 0; x < X; x++)
                {
                    int b = (x >> k) << k;
                    for (int j = b; j < b + (1 << k); j++)
                    {
                        if ((x >> (k - 1) & 1) == (j >> (k - 1) & 1)) continue;
                        DP[x, k] += DP[x, k - 1] * DP[j, k - 1] * P[j, x];
                    }
                }
            }

            for (int i = 0; i < X; i++)
            {
                Console.WriteLine(DP[i, K]);
            }
        }
    }
}
