using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC171
{
    class D
    {
        static void Main(string[] args)
        {
            //var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var p = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var Q = long.Parse(Console.ReadLine());
            var BC = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            var count = new int[100010];
            for (int i = 0; i < A.Length; i++)
            {
                count[A[i]]++;
            }

            var sum = new int[100010];
            for (int i = 0; i < count.Length; i++)
            {
                sum[i] = count[i] * i;
            }


            var Asum = A.Sum();
            for (int i = 0; i < Q; i++)
            {
                Console.WriteLine(Asum - sum[BC[i][0]] + sum[BC[i][1]]);
            }

        }
    }
}
