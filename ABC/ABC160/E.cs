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
            var p = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).Take((int)X).ToArray();
            var q = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).Take((int)Y).ToArray();
            var r = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();

            var pqr = p.Concat(q).Concat(r).OrderByDescending(x => x).ToArray();

            var sum = 0L;
            for (int i = 0; i < X + Y; i++)
            {
                sum += pqr[i];
            }

            Console.WriteLine(sum);

        }
    }
}
