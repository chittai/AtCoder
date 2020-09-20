using System;
using System.IO;
using System.Linq;

namespace ABC107
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long K = input[1];

            long[] x = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long[] Res = new long[N - K + 1];
            for (long i = 0; i < N - K + 1; i++)
            {
                Res[i] = Math.Min(Math.Abs(x[i]) + Math.Abs(x[i + K - 1] - x[i]), Math.Abs(x[i + K - 1]) + Math.Abs(x[i + K - 1] - x[i]));
            }

            Console.WriteLine(Res.Min());
        }
    }
}
