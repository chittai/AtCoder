using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC166
{
    class C
    {
        static void Main(string[] args)
        {
            //var N = long.Parse(Console.ReadLine());
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NK[0]; var M = NK[1];
            //var S = Console.ReadLine();
            var H = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var AB = Enumerable.Repeat(0, (int)M).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            var res = new long[N];

            for (int i = 0; i < M; i++)
            {
                var A = AB[i][0] - 1;
                var B = AB[i][1] - 1;
                if (H[A] < H[B]) res[A] = 1;
                if (H[A] > H[B]) res[B] = 1;
                if (H[A] == H[B])
                {
                    res[A] = 1; res[B] = 1;
                }

            }
            var ans = res.Count(x => x == 0);
            Console.WriteLine(ans);

        }
    }
}
