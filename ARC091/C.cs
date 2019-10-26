using System;
using System.Linq;

namespace ARC091
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = input[0];
            var M = input[1];
            if (N == 1 && M == 1) Console.WriteLine(1);
            else if (N == 1 || M == 1) Console.WriteLine(N * M - 2);
            else Console.WriteLine(N * M - (2 * N + 2 * M - 4));
        }
    }
}
