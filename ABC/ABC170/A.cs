using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC170
{
    class A
    {
        static void Main(string[] args)
        {
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int i = 0; i < 5; i++)
            {
                if (A[i] == 0) Console.WriteLine(i + 1);
            }

        }
    }
}
