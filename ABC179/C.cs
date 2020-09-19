using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC179
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            //var ans = false;
            var ans = 0;
            for (int i = 1; i < Math.Sqrt(N); i++)
            {
                for (int j = i; i * j < N; j++)
                {
                    if (i == j) ans++;
                    else ans += 2;

                }
            }
            Console.WriteLine(ans);
        }
    }
}
