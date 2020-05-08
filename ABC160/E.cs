using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC160
{
    class E
    {
        static void Main(string[] args)
        {
            var XYABC = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var X = XYABC[0]; var Y = XYABC[1]; var A = XYABC[2]; var B = XYABC[3]; var C = XYABC[4];
            var p = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();
            var q = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();
            var r = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();

            //Console.WriteLine(string.Join(" ", p));
            //Console.WriteLine(string.Join(" ", q));
            //Console.WriteLine(string.Join(" ", r));

            var res = 0L;
            var indexp = 0;
            var indexq = 0;
            var indexr = 0;

            var xlimit = X;
            var ylimit = Y;
            for (int i = 0; i < Math.Max(X, Y); i++)
            {
                var pmax = 0L;
                var qmax = 0L;
                var rmax = 0L;
                if (indexp < X) pmax = p[indexp];
                if (indexq < Y) qmax = q[indexq];
                if (indexr < C) rmax = r[indexr];

                if (pmax == 0 || qmax == 0)
                {
                    if (pmax == 0)
                    {
                        if (qmax > rmax) { res += qmax; indexq++; }
                        else { res += rmax; indexr++; }
                    }
                    else if (qmax == 0)
                    {
                        if (pmax > rmax) { res += pmax; indexp++; }
                        else { res += rmax; indexr++; }
                    }
                }
                else
                {
                    if (pmax >= qmax && rmax > qmax) { res += pmax + rmax; indexp++; indexr++; }
                    else if (pmax <= qmax && rmax > qmax) { res += qmax + rmax; indexq++; indexr++; }
                    else { res += qmax + pmax; indexq++; indexp++; }
                }
            }

            Console.WriteLine(res);

        }
    }
}
