using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC170
{
    class B
    {
        static void Main(string[] args)
        {
            var XN = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine(XN[0]);
                return;
            }

            var p = input.Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var ans = long.MaxValue;
            var temp = long.MaxValue;
            for (int i = 210; i >= 0; i--)
            {
                if (!p.Contains(i))
                {
                    if (Math.Abs(XN[0] - i) <= temp) { temp = Math.Abs(XN[0] - i); ans = i; }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
