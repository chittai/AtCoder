using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ABC126_1
{
    class D
    {

        static List<long>[] Nodes;
        static long[] Res;
        //static long[,] Dist;
        static List<long>[] Dist;
        static void Main(string[] args)
        {

            //StreamReader r = new StreamReader(@"./testcase");

            var n = long.Parse(Console.ReadLine());
            //var n = long.Parse(r.ReadLine());
            Nodes = new List<long>[n].Select(x => x = new List<long>()).ToArray();
            Dist = new List<long>[n].Select(x => x = new List<long>()).ToArray();
            Res = new long[n];

            for (int i = 0; i < n - 1; i++)
            {
                var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
                //var a = r.ReadLine().Split().Select(long.Parse).ToArray();
                // ノード間の接続情報
                Nodes[a[0] - 1].Add(a[1]);
                Nodes[a[1] - 1].Add(a[0]);
                // 2点間の距離
                Dist[a[0] - 1].Add(a[2] % 2);
                Dist[a[1] - 1].Add(a[2] % 2);
            }

            /*
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Join(",", Dist[i, j]));
                }
                Console.WriteLine();
            }
            */

            dfs(0, 1, 0);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Res[i]);
            }
        }


        static void dfs(long preNode, long nowNode, long distSum)
        {
            if (distSum % 2 == 0) Res[nowNode - 1] = 0;
            if (distSum % 2 == 1) Res[nowNode - 1] = 1;

            for (int i = 0; i < Nodes[nowNode - 1].Count; i++)
            {
                var nextNode = Nodes[nowNode - 1][i];
                if (preNode != nextNode) dfs(nowNode, nextNode, distSum + Dist[nowNode - 1][i]);
            }

            /*
            foreach (var nextNode in Nodes[nowNode - 1])
            {
                // 前のノードの接続情報は無視する
                if (preNode != nextNode) dfs(nowNode, nextNode, distSum + Dist[nowNode - 1, nextNode - 1]);
            }
            */
        }
    }
}
