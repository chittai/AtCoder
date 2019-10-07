using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC126
{
    class Dist
    {
        public long nextvertex { get; set; }
        public long distance { get; set; }

        public Dist(long v, long d)
        {
            nextvertex = v;
            distance = d;
        }
    }

    class D
    {
        static long[] Res;
        static List<Dist>[] list;

        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            Res = new long[N];
            list = new List<Dist>[N];

            long[] input;
            long u = 0;
            long v = 0;
            long w = 0;
            for (long i = 0; i < N - 1; i++)
            {
                input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                u = input[0] - 1;
                v = input[1] - 1;
                if (input[2] % 2 == 0) w = 0;
                else if (input[2] % 2 == 1) w = 1;

                if (list[u] == null) list[u] = new List<Dist>();
                if (list[v] == null) list[v] = new List<Dist>();
                list[u].Add(new Dist(v, w));
                list[v].Add(new Dist(u, w));
            }

            DFS(0, 0, 0, 0);

            foreach (var item in Res)
            {
                Console.WriteLine(item);
            }
        }

        static void DFS(long now, long previous, long sumdist, long w)
        {
            sumdist += w;
            if (sumdist % 2 == 0) Res[now] = 0;
            if (sumdist % 2 == 1) Res[now] = 1;

            foreach (var item in list[now])
            {
                if (item.nextvertex != previous) DFS(item.nextvertex, now, sumdist, item.distance);
            }
        }
    }
}