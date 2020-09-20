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
            //var N = long.Parse(Console.ReadLine());
            var abcd = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            var ans = new long[4];
            ans[0] = abcd[0] * abcd[2];
            ans[1] = abcd[0] * abcd[3];
            ans[2] = abcd[1] * abcd[2];
            ans[3] = abcd[1] * abcd[3];

            Console.WriteLine(ans.Max());

        }
    }
}
