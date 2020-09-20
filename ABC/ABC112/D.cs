using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC112
{
    class D
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long M = input[1];

            long res = 0;

            for (long i = 1; i <= Math.Sqrt(M) + 1; i++)
            {

                if (M % i == 0)
                {
                    if (i <= M / N) res = Math.Max(res, i);
                    if (M / i <= M / N) res = Math.Max(res, M / i);
                }

            }
            Console.WriteLine(res);

        }
    }
}
