using System;
using System.Linq;

namespace ARC069
{
    class A
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long M = input[1];

            long res = 0;
            if (2 * N < M)
            {
                res = N + (M / 2 - N) / 2;
            }
            else
            {
                res = M / 2;
            }
            Console.WriteLine(res);
        }
    }
}
