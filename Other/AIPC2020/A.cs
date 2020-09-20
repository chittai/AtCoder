using System;
using System.Linq;
using System.Collections.Generic;

namespace AIPC2020
{
    class A
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            var LRd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var N = long.Parse(Console.ReadLine());

            var ans = 0;
            for (int i = LRd[0]; i <= LRd[1]; i++)
            {
                if (i % LRd[2] == 0) ans++;
            }

            Console.WriteLine(ans);
        }
    }
}
