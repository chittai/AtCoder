using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC171
{
    class B
    {
        static void Main(string[] args)
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var p = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            //var NK = Console.ReadLine();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var sum = 0L;
            for (int i = 0; i < NK[1]; i++)
            {
                sum += p[i];
            }
            Console.WriteLine(sum);
        }
    }
}
