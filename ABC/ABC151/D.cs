using System;
using System.Linq;
using System.Collections.Generic;
namespace ABC151
{
    class D
    {
        static int X;
        static int Y;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Y = input[0];
            X = input[1];

            char[,] map = new char[X, Y];
            for (int y = 0; y < Y; y++)
            {
                var s = Console.ReadLine();
                for (int x = 0; x < X; x++)
                {
                    map[x, y] = s[x];
                }
            }

            // tupleで組み合わせを作成
            int res = 0;
            List<Tuple<int, int, int, int>> t = new List<Tuple<int, int, int, int>>();
            for (int sy = 0; sy < Y; sy++)
            {
                for (int sx = 0; sx < X; sx++)
                {
                    if (map[sx, sy] == '#') continue;

                    res = Math.Max(BFS(sx, sy, map), res);

                }
            }
            Console.WriteLine(res);
        }

        static int BFS(int sx, int sy, char[,] map)
        {
            int[,] dist = new int[X, Y];
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    dist[x, y] = -1;
                }
            }

            Queue<Tuple<int, int, int>> tq = new Queue<Tuple<int, int, int>>();
            int step = 0;
            tq.Enqueue(Tuple.Create(sx, sy, step));
            dist[sx, sy] = 0;

            int[] vx = { 0, 1, 0, -1 };
            int[] vy = { 1, 0, -1, 0 };
            while (0 < tq.Count)
            {
                var q = tq.Dequeue();
                int x = q.Item1;
                int y = q.Item2;
                step = q.Item3;

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + vx[i];
                    int ny = y + vy[i];

                    if ((0 <= nx && nx < X) && (0 <= ny && ny < Y) && map[nx, ny] == '.' && dist[nx, ny] == -1)
                    {
                        dist[nx, ny] = dist[x, y] + 1;
                        tq.Enqueue(Tuple.Create(nx, ny, step + 1));
                    }
                }
            }
            return step;
        }
    }
}