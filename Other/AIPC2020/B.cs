using System;
using System.Linq;
using System.Collections.Generic;

namespace AIPC2020
{
    class B
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var LRd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var ans = 0;
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0 && a[i] % 2 == 1) ans++;
            }

            Console.WriteLine(ans);
        }
    }
}
