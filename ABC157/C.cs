using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC157
{
    class C
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = input[0];
            var M = input[1];
            var sc = Enumerable.Repeat(0, M).Select(_ => Console.ReadLine().Split().Select(int.Parse).ToArray()).ToArray();

            for (int i = 0; i < 1000; i++)
            {
                var s = i.ToString();
                if (s.Length != N) continue;
                if (!sc.All(x => s[x[0] - 1] - '0' == x[1])) continue;
                Console.WriteLine(i);
                return;
            }
            Console.WriteLine(-1);
        }
    }
}