using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC159
{
    class D
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            //出てきた数字の数
            var count = new long[n + 1];
            for (long i = 0; i < n; i++)
            {
                count[A[i]]++;
            }

            //nCkしたやつ
            var res = new long[n + 1];
            for (long i = 0; i < n; i++)
            {
                res[A[i]] = count[A[i]] * (count[A[i]] - 1) / 2;
            }

            long sum = res.Sum();

            for (long i = 0; i < n; i++)
            {
                long tmpSum = sum - res[A[i]] + (count[A[i]] - 1) * (count[A[i]] - 1 - 1) / 2;

                Console.WriteLine(tmpSum);
            }
        }
    }
}
