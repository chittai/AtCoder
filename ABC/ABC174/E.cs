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
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NK[0]; var K = NK[1];
            var A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            var ok = A.Max();
            var ng = 0L;

            while (1 < Math.Abs(ok - ng))
            {
                var m = (ok + ng) / 2;
                var cnt = 0L;
                for (int i = 0; i < N; i++)
                {
                    cnt += (long)Math.Ceiling((double)A[i] / (double)m) - 1;
                }

                if (cnt <= K)
                    ok = m;
                else
                    ng = m;

            }
            Console.WriteLine(ok);
        }
    }
}
