using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC176
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            var sum = 0L;
            var max = A[0];
            for (int i = 0; i < N; i++)
            {
                if (A[i] < max) { sum += max - A[i]; A[i] += max - A[i]; }
                if (max < A[i]) max = A[i];
            }

            Console.WriteLine(sum);

        }
    }
}
