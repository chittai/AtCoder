using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC168
{
    class D
    {
        static void Main(string[] args)
        {
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Enumerable.Repeat(0, (int)M).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();            
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NM[0]; var M = NM[1];

            // node は 0index に変更する
            List<long>[] list = new List<long>[N];
            for (int i = 0; i < N; i++)
            {
                list[i] = new List<long>();
            }

            for (int i = 0; i < M; i++)
            {
                var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
                var A = AB[0] - 1; var B = AB[1] - 1;
                list[A].Add(B);
                list[B].Add(A);
            }

            var res = new long[N];
            var visited = new bool[N];
            Queue<long> tq = new Queue<long>();
            tq.Enqueue(0);
            visited[0] = true;
            //dist[sx, sy] = 0;
            ///int[] vx = { 0, 1, 0, -1 };
            ///int[] vy = { 1, 0, -1, 0 };
            while (0 < tq.Count)
            {
                var next = tq.Dequeue();

                for (int i = 0; i < list[next].Count; i++)
                {
                    // int nx = x + vx[i];
                    // int ny = y + vy[i];

                    if (!visited[list[next][i]])
                    {
                        visited[list[next][i]] = true;
                        res[list[next][i]] = next + 1;
                        tq.Enqueue(list[next][i]);
                    }
                }
            }
            //Console.WriteLine(string.Join(" ", res));
            Console.WriteLine("Yes");
            for (int i = 1; i < N; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
