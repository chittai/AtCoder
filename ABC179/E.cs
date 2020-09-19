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
            var NXM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NXM[0]; var X = NXM[1]; var M = NXM[2];

            var a_ = X;
            var sum = X;
            var count = 1L;
            var Count = new long[M];
            Count[a_]++;

            for (int i = 0; i < M; i++)
            {
                a_ = (a_ * a_) % M;
                if (Count[a_] + 1 == 3) break;
                Count[a_]++;
                count++;
                sum += a_;
            }

            //Console.WriteLine(count);

            var ans = 0L;
            var a = N / count;
            var b = N % count;
            ans += a * sum;

            //Console.WriteLine(ans);

            if (0 < b)
            {
                ans += X;
                a_ = X;
                for (int i = 0; i < b - 1; i++)
                {
                    a_ = (a_ * a_) % M;
                    ans += a_;
                    //Console.WriteLine("ans: " + ans);
                }
            }

            //Console.WriteLine(count);
            //Console.WriteLine(string.Join(" ", Count));
            Console.WriteLine(ans);
        }

        // 循環開始・終了位置

    }
}
