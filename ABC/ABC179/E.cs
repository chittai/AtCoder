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

            // make array
            var array = new long[M + 100];
            var a_ = X;
            array[0] = a_;
            for (int i = 1; i < M; i++)
            {
                a_ = (a_ * a_) % M;
                array[i] = a_;
            }

            //Console.WriteLine(string.Join(" ", array));

            var t = Program.cycle_finding(array);
            var s = t.Item1; var e = t.Item2; var len = t.Item3;
            //Console.WriteLine("{0}, {1}", s, e);

            N -= s;
            var ans = 0L;
            for (int i = 0; i < s; i++)
            {
                ans += array[i];
            }

            var a = N / len;
            var b = N % len;

            var sum = 0L;
            for (long i = s; i <= e; i++)
            {
                sum += array[i];
            }

            ans += a * sum;

            for (int i = 0; i < b; i++)
            {
                ans += array[s + i];
            }

            Console.WriteLine(ans);


        }

        // 循環開始・終了位置
        static Tuple<long, long, long> cycle_finding(long[] a)
        {
            var x_length = new long[a.Length].Select(x => x = -1).ToArray();
            var s = 0L;
            var e = 0L;

            var len = 0;
            var index = 0;
            for (int i = 0; x_length[a[i]] == -1; i++)
            {
                x_length[a[i]] = len;
                len++;
                index = i;
            }
            var cycle_length = len - x_length[a[index + 1]];

            s = x_length[a[index + 1]];
            e = x_length[a[index]];
            //Console.WriteLine("{0}, {1}", s, e);
            //Console.WriteLine(string.Join(" ", x_length));

            var tuple = Tuple.Create(s, e, cycle_length);
            return tuple;
        }

    }
}
