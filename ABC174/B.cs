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
            var ND = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var N = ND[0]; var D = ND[1];
            var ans = 0;
            for (int i = 0; i < N; i++)
            {
                var XY = Console.ReadLine().Split().Select(double.Parse).ToArray();
                var dis = Math.Sqrt(Math.Pow(XY[0], 2) + Math.Pow(XY[1], 2));
                if (dis <= D) ans++;
            }

            Console.WriteLine(ans);

        }
    }
}
