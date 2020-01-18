using System;
using System.Linq;
using System.Collections.Generic;

namespace KEYENCE2020
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long K = input[1];
            long S = input[2];
            long[] res = new long[N];
            long Max = 1000000000;

            for (long i = 0; i < K; i++)
            {
                res[i] = S;
            }

            for (long i = K; i < N; i++)
            {
                if (S == Max) res[i] = Max - 1;
                else res[i] = S + 1;
            }
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
