using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC160
{
    class C
    {
        static void Main(string[] args)
        {
            var kn = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var k = kn[0]; var n = kn[1];
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var asum = a.Sum();
            var sa = new long[n];
            sa[0] = Math.Abs(k - a[a.Length - 1] + a[0]);

            for (int i = 1; i < n; i++)
            {
                sa[i] = Math.Abs(a[i] - a[i - 1]);
            }

            Console.WriteLine(sa.Sum() - sa.Max());

        }
    }
}
