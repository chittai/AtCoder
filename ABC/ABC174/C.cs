using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC174
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var p = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            var K = long.Parse(Console.ReadLine());
            var x = 7L;
            for (long i = 0; i <= K; i++)
            {
                if (x % K == 0) { Console.WriteLine(i + 1); return; }
                x = (10 * x + 7) % K;
            }
            Console.WriteLine(-1);
        }
    }
}
