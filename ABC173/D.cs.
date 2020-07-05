using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC173
{
    class D
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray()
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();

            var sum = A[0];
            var index = 1;
            for (int i = 1; i < N - 1; i++)
            {
                sum += A[index];
                if (i % 2 == 0)
                {
                    index++;
                }
            }
            //Console.WriteLine(string.Join(" ", A));
            Console.WriteLine(sum);
        }
    }
}
