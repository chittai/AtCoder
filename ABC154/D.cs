using System;
using System.Linq;

namespace ABC154
{
    class D
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            double[] p = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] Kitai = new double[N];

            for (int i = 0; i < N; i++)
            {
                Kitai[i] = (1 + p[i]) / 2;
            }

            double[] S = new double[N + 1];
            for (int i = 1; i < N + 1; i++)
            {
                S[i] = Kitai[i - 1] + S[i - 1];
            }

            double res = 0.0;
            for (int i = 0; i < N - K + 1; i++)
            {
                res = Math.Max(res, S[i + K] - S[i]);
            }

            /*
            for (int i = 0; i < N - K + 1; i++)
            {
                double kitai = 0.0;
                for (int k = 0; k < K; k++)
                {
                    if (p[i + k] == 1) kitai += 1.0;
                    else kitai += (1 + p[i + k]) / 2;
                    //Console.WriteLine(kitai);
                }
                res = Math.Max(res, kitai);
            }
            */
            Console.WriteLine(res);
        }
    }
}
