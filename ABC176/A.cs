using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC176
{
    class Program
    {
        static void Main(string[] args)
        {
            var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            // var A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var N = long.Parse(Console.ReadLine());
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            Console.WriteLine(Math.Ceiling(NXT[0] / NXT[1]) * NXT[2]);

        }
    }
}
