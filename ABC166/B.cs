using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC166
{
    class B
    {
        static void Main(string[] args)
        {
            //var N = long.Parse(Console.ReadLine());
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NK[0]; var K = NK[1];
            //var abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var S = Console.ReadLine();

            var res = new int[N];
            for (int i = 0; i < K; i++)
            {
                var d = long.Parse(Console.ReadLine());
                var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int j = 0; j < d; j++)
                {
                    res[A[j] - 1]++;
                }
            }

            var ans = res.Count(x => x == 0);
            Console.WriteLine(ans);

        }
    }
}
