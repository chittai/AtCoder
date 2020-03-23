using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ABC126_1
{

    class D
    {
        public struct Edge
        {
            public int to;
            public int weight;
            public Edge(int t, int w) { to = t; weight = w; }
        }
        static List<Edge>[] Nodes;
        static bool[] seen;
        static long[] Res;
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Nodes = new List<Edge>[n].Select(x => x = new List<Edge>()).ToArray();
            seen = new bool[n];
            Res = new long[n];
            for (int i = 0; i < n - 1; i++)
            {
                var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Nodes[a[0] - 1].Add(new Edge(a[1], a[2] % 2));
                Nodes[a[1] - 1].Add(new Edge(a[0], a[2] % 2));
            }

            dfs(1, 0);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Res[i]);
            }
        }

        static void dfs(int v, int count)
        {
            seen[v - 1] = true;
            Res[v - 1] = count % 2;
            foreach (var next_v in Nodes[v - 1])
            {
                if (seen[next_v.to - 1]) continue;
                dfs(next_v.to, count + next_v.weight);
            }
        }
    }
}
