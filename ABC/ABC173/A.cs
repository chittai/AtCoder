using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC173
{
    class A
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var NMK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());

            while (1000 < N)
            {
                N -= 1000;
            }

            Console.WriteLine(1000 - N);
        }
    }
}
