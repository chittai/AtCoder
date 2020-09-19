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
            var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            var ans = false;
            for (int i = 0; i < N - 3 + 1; i++)
            {
                if (CA[i][0] != CA[i][1]) continue;
                if (CA[i + 1][0] != CA[i + 1][1]) continue;
                if (CA[i + 2][0] != CA[i + 2][1]) continue;
                ans = true;
            }

            if (ans) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
