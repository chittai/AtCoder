using System;
using System.Linq;

namespace ABC067
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long[] S = new long[N + 1];
            for (long i = 0; i < N; i++)
            {
                S[i + 1] = S[i] + a[i];
            }

            long res = long.MaxValue;
            for (long i = 1; i < N; i++)
            {
                long x = S[N] - S[i];
                long y = S[i];
                res = Math.Min(res, Math.Abs(x - y));
            }
            Console.WriteLine(res);
        }
    }
}
