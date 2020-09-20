using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC165
{
    class B
    {
        static long N;
        static long M;
        static long Q;
        static long[][] abcd;
        static long ans;
        static void Main(string[] args)
        {
            //var X = long.Parse(Console.ReadLine());
            var NMQ = Console.ReadLine().Split().Select(long.Parse).ToArray();
            N = NMQ[0]; M = NMQ[1]; Q = NMQ[2];
            abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            var list = new List<long>();
            DFS(1, list, N);

            Console.WriteLine(ans);
        }

        static void DFS(int min, List<long> list, long len)
        {
            if (len == 0)
            {
                long sum = 0;
                for (int q = 0; q < Q; q++)
                {
                    if (list[(int)abcd[q][1] - 1] - list[(int)abcd[q][0] - 1] == abcd[q][2]) sum += abcd[q][3];
                }
                ans = Math.Max(ans, sum);
                return;
            }

            for (int i = min; i <= M; i++)
            {
                list.Add(i);
                DFS(i, list, len - 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
