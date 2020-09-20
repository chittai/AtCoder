using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC170
{
    class D
    {
        static void Main(string[] args)
        {
            //var XN = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var input = Console.ReadLine();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var Amax = A.Max();
            var Ans = new long[Amax + 10];
            for (int i = 0; i < A.Length; i++)
            {
                var index = 1;
                while (A[i] * index <= Amax)
                {
                    Ans[A[i] * index]++;
                    index++;
                }
            }

            var ans = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (Ans[A[i]] == 1) ans++;
            }

            Console.WriteLine(ans);
        }
    }
}