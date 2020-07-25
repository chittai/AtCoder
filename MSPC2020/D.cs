using System;
using System.Linq;
using System.Collections.Generic;

namespace MSPC2020
{
    class D
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var LRd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var X = int.Parse(Console.ReadLine());
            //var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var total = 1000;
            var stock = 0;
            for (int i = 0; i < N - 1; i++)
            {
                var now = A[i];
                var next = A[i + 1];
                if (now < next && 0 < total / now)
                {
                    stock += total / now;
                    total = total % now;
                }
                else if (now > next)
                {
                    if (0 < stock)
                    {
                        total += stock * now;
                        stock = 0;
                    }
                }
            }
            if (0 < stock)
            {
                total += A[N - 1] * stock;
            }
            Console.WriteLine(total);
        }
    }
}
