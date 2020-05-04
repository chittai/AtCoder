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
        static void Main(string[] args)
        {
            //var X = long.Parse(Console.ReadLine());
            var NMQ = Console.ReadLine().Split().Select(long.Parse).ToArray();
            N = NMQ[0]; M = NMQ[1]; Q = NMQ[2];
            var abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            long ans = 0;
            for (int bit = 0; bit < (1 << 10); bit++)
            {
                var list = new List<int>();
                for (int i = 0; i < M; i++)
                {
                    if ((bit & (1 << i)) > 0) list.Add(i + 1);
                }
                if (list.Count != N) continue;
                Console.WriteLine(string.Join(" ", list));
                long sum = 0;
                for (int q = 0; q < Q; q++)
                {
                    //Console.WriteLine(list[(int)abcd[q][1] - 1]);
                    if (list[(int)abcd[q][1] - 1] - list[(int)abcd[q][0] - 1] == abcd[q][2]) { sum += abcd[q][3]; }
                }
                ans = Math.Max(ans, sum);
                //if (ans == 219802) { Console.WriteLine(string.Join(" ", list)); break; };

            }
            Console.WriteLine(ans);
        }

        static void DFS(int len)
        {
            if (len == N)
            {

            }

        }

    }
}
