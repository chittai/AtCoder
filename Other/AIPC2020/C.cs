using System;
using System.Linq;
using System.Collections.Generic;

namespace AIPC2020
{
    class C
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (long)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var LRd = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            //var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var n = new int[N + 10];
            for (long x = 1; x <= 100; x++)
            {
                for (long y = 1; y <= 100; y++)
                {
                    for (long z = 1; z <= 100; z++)
                    {
                        var sum = Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + (x * y) + (y * z) + (z * x);
                        if (sum <= N) n[(long)sum]++;
                    }
                }
            }
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
