using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC174
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var p = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            var S = Console.ReadLine();

            var Wcount = 0;
            var Rcount = S.Count(x => x == 'R');

            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'W') Wcount++;
                else Rcount--;

                if (Wcount == Rcount) { Console.WriteLine(Wcount); return; }

            }
            Console.WriteLine(0);
        }
    }
}
