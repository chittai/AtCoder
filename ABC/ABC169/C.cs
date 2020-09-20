using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC169
{
    class C
    {
        static void Main(string[] args)
        {
            // var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var N = long.Parse(Console.ReadLine());
            var AB = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            Console.WriteLine((decimal)Math.Floor(AB[0] * AB[1]));
        }
    }
}
