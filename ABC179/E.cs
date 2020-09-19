using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC179
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //var N = long.Parse(Console.ReadLine());
            var NXM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NXM[0]; var X = NXM[1]; var M = NXM[2];
            //var LR = Enumerable.Repeat(0, (int)K).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            //var ans = false;
            //var ans = 0;
            var temp = X;
            var count = 0L;
            var Count = new long[M];
            for (int i = 1; i < M; i++)
            {
                //if (M <= temp * X % M) break;
                temp = (temp * X) % M;
                Count[temp]++;
                //count
            }

            count = Count.Count(x => x != 0);

            var n = N / count;

            var sum = 0L;
            if (n == 0)
            {
                var x = 0;
                for (int i = 0; i < M; i++)
                {
                    if (Count[i] != 0)
                    {
                        x++;
                        sum += Count[i];
                    }
                    if (N <= x) break;
                }
            }
            else
            {
                
            }


            Console.WriteLine(count * n);
            //Console.WriteLine(string.Join(" ", Count));
            //Console.WriteLine(ans);
        }
    }
}
