using System;
using System.Linq;

namespace DDCC2020
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long[] S = new long[N + 1];
            for (int i = 0; i < N; i++)
            {
                S[i + 1] = S[i] + A[i];
            }

            long res = long.MaxValue;
            for (int i = 0; i < N + 1; i++)
            {
                long L = S[i];
                long R = S[N] - S[i];

                res = Math.Min(res, Math.Abs(L - R));
            }
            Console.WriteLine(res);
        }
    }
}
