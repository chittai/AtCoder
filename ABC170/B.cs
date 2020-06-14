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
            var XY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int i = 0; i <= XY[0]; i++)
            {
                for (int j = 0; j <= XY[0] - i; j++)
                {
                    if (i + j == XY[0] && 2 * i + 4 * j == XY[1]) { Console.WriteLine("Yes"); return; }
                }
            }
            Console.WriteLine("No");
        }
    }
}
