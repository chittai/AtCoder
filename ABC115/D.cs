using System;
using System.Linq;

namespace ABC115
{
    class Program
    {

        static long[] P;
        static long[] A;

        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long N = input[0];
            long X = input[1];

            P = new long[N + 1];
            A = new long[N + 1];

            P[0] = 1;
            A[0] = 1;

            for (int i = 1; i < N; i++)
            {
                P[i] = 2 * P[i - 1] + 1;
                A[i] = 2 * A[i - 1] + 3;
            }
            Console.WriteLine(f(N, X));
        }

        static long f(long N, long X)
        {
            if (N == 0) { if (X <= 0) return 0; else return 1; }
            else if (X <= 1 + A[N - 1]) return f(N - 1, X - 1);
            else return P[N - 1] + 1 + f(N - 1, X - 2 - A[N - 1]);
        }
    }
}
