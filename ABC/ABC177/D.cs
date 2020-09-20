
using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace ABC177
{
    class Program
    {
        static void Main(string[] args)
        {
            var NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NM[0]; var M = NM[1];
            var CA = Enumerable.Repeat(0, (int)M).Select(_ => Console.ReadLine().Split().Select(int.Parse).ToArray()).OrderBy(x => x[0]).ToArray();

            UF uf = new UF(N);
            for (int i = 0; i < M; i++)
            {
                uf.Unite(CA[i][0] - 1, CA[i][1] - 1);
            }

            //var ans = 0;
            var count = new int[uf.parent.Max() + 1];
            for (int i = 0; i < N; i++)
            {
                count[uf.parent[i]]++;
            }

            //Console.WriteLine(string.Join(" ", uf.parent));
            Console.WriteLine(count.Max());

        }
    }

    class UF
    {
        public int[] parent;
        public UF(int N) { parent = Enumerable.Range(0, N).ToArray(); }

        int root(int x)
        {
            if (parent[x] == x) return x;
            return parent[x] = root(parent[x]);
        }

        public void Unite(int x, int y)
        {
            int rx = root(x);
            int ry = root(y);
            if (rx == ry) return;
            parent[rx] = ry;
        }
        public bool CheckSame(int x, int y)
        {
            int rx = root(x);
            int ry = root(y);
            return rx == ry;
        }
    }
}