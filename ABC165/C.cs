using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC165
{
    class B
    {
        static void Main(string[] args)
        {
            //var X = long.Parse(Console.ReadLine());
            var NMQ = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NMQ[0]; var M = NMQ[1]; var Q = NMQ[2];

            var abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            abcd = abcd.OrderByDescending(x => x[3]).ToArray();
            //abcd = abcd.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();
            Console.WriteLine("----------");
            for (long i = 0; i < Q; i++)
            {
                Console.WriteLine(string.Join(" ", abcd[i]));
            }


        }
    }
}
