using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC178
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            //var abcd = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            var x = 1000000007L;
            var a = 1L;
            var b = 1L;
            var c = 1L;
            for (int i = 0; i < N; i++)
            {
                a = (a * 10) % x;
                b = (b * 9) % x;
                c = (c * 8) % x;

            }

            var ans = (a - ((2 * b) % x - c)) % x;
            if (ans < 0) Console.WriteLine(ans + x);
            else Console.WriteLine(ans);

        }
    }
}
