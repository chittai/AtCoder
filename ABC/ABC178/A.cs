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
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            if (N == 0) Console.WriteLine(1);
            else Console.WriteLine(0);

        }
    }
}