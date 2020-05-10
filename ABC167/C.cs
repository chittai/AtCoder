using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC167
{
    class C
    {
        static void Main(string[] args)
        {
            var NMX = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NMX[0]; var M = NMX[1]; var X = NMX[2];
            var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            var ans = long.MaxValue;
            for (int bit = 0; bit < (1 << (int)N); bit++)
            {
                var res = new long[M];
                var sum = 0L;
                for (int i = 0; i < N; i++)
                {
                    if ((bit & (1 << i)) > 0)
                    {
                        sum += CA[i][0];
                        for (int j = 0; j < M; j++)
                        {
                            res[j] += CA[i][j + 1];
                        }
                    }
                }
                if (res.Count(x => X <= x) == M) ans = Math.Min(ans, sum);

            }

            if (ans == long.MaxValue) Console.WriteLine(-1);
            else Console.WriteLine(ans);

        }
    }
}

