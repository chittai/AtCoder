using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC127
{
    class D
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long N = long.Parse(input[0]);
            long M = long.Parse(input[1]);
            long[] a = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            long[] B = new long[M];
            long[] C = new long[M];

            Dictionary<long, long> dict = new Dictionary<long, long>();
            for (long i = 0; i < N; i++)
            {
                if (!dict.ContainsKey(a[i])) dict.Add(a[i], a.Count(x => x == a[i]));
            }

            for (long i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split();
                B[i] = long.Parse(input[0]);
                C[i] = long.Parse(input[1]);

                if (!dict.ContainsKey(C[i])) dict.Add(C[i], B[i]);
                else dict[C[i]] += B[i];
            }

            var dict2 = dict.OrderByDescending(x => x.Key);

            long res = 0;
            long count = 0;
            foreach (var item in dict2)
            {
                if (count + item.Value <= N) { res += item.Key * item.Value; count += item.Value; }
                else { res += item.Key * (N - count); Console.WriteLine(res); return; }
            }

            Console.WriteLine(res);

            /*
            foreach (var item in dict2)
            {
                Console.Write(item.Key);
                Console.Write(' ');
                Console.WriteLine(item.Value);
            }
            */
        }
    }
}
