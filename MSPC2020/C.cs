using System;
using System.Linq;
using System.Collections.Generic;

namespace MSPC2020
{
    class C
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var LRd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var X = int.Parse(Console.ReadLine());
            //var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NK[0]; var K = NK[1];
            for (long i = 0; i < N - K; i++)
            {
                var L = A[i];
                var R = A[i + K];

                if (L < R) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }

        }
    }
}
