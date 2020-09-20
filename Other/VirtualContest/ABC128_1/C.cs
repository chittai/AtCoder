using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC128_1
{
    class C
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = a[0]; var M = a[1];
            var b = Enumerable.Repeat(0, M).Select(_ => Console.ReadLine().Split().Select(int.Parse).ToArray()).ToArray();
            var p = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var res = 0;
            for (int bit = 0; bit < (1 << N); bit++)
            {
                bool all = true;
                // 各電球の数繰り返す
                for (int i = 0; i < M; i++)
                {
                    var total = 0;
                    for (int j = 1; j <= b[i][0]; j++)
                    {
                        if ((bit & (1 << (b[i][j] - 1))) > 0) total++;
                    }
                    if (total % 2 != p[i]) { all = false; }
                }
                if (all) res++;
            }
            Console.WriteLine(res);
        }
    }
}
