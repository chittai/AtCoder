using System;
using System.Linq;

namespace ARC043
{
    class A
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int N = (int)input[0];
            double A = input[1];
            double B = input[2];
            double[] S = new double[N];
            for (int i = 0; i < N; i++)
            {
                S[i] = int.Parse(Console.ReadLine());
            }

            if (S.Max() - S.Min() != 0)
            {
                double p = B / (S.Max() - S.Min());
                double q = A - p * S.Sum() / N;
                Console.WriteLine("{0} {1}", p, q);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
