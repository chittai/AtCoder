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
                DP[i, 0] = 1d;
            }

            for (int i = 0; i < X; i++)
            {
                for (int j = 1; j < K; j++)
                {
                    double sum = 0.0;
                    for (int k = 0; k < X; k++)
                    {
                        sum += DP[k, j - 1];
                    }
                    DP[i, j] = DP[i, j - 1] * sum * P;
                }
            }

            for (int i = 0; i < X; i++)
            {
                Console.WriteLine(DP[i, K]);
            }


        }
    }
}
