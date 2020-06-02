using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC169
{
    class A
    {
        static void Main(string[] args)
        {
            // var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            Console.WriteLine(AB[0] * AB[1]);
        }
    }
}