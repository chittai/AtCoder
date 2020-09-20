using System;
using System.Collections.Generic;

namespace ABC007
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input;
            input = Console.ReadLine().Split(' ');
            int R = int.Parse(input[0]);
            int C = int.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            int sy = int.Parse(input[0]) - 1;
            int sx = int.Parse(input[1]) - 1;

            input = Console.ReadLine().Split(' ');
            int gy = int.Parse(input[0]) - 1;
            int gx = int.Parse(input[1]) - 1;

            char[,] map = new char[C, R];
            for (int i = 0; i < R; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < C; j++)
                {
                    map[j, i] = s[j];
                }
            }

            Queue<Tuple<int, int, int>> tq = new Queue<Tuple<int, int, int>>();
            tq.Enqueue(Tuple.Create(sx, sy, 0));
            int step = 0;
            map[sx, sy] = '#';

            int[] vx = { 0, 1, 0, -1 };
            int[] vy = { 1, 0, -1, 0 };

            while (0 < tq.Count)
            {
                var q = tq.Dequeue();
                int x = q.Item1;
                int y = q.Item2;
                step = q.Item3;

                if (x == gx && y == gy)
                {
                    Console.WriteLine(step);
                    return;
                }

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + vx[i];
                    int ny = y + vy[i];

                    if ((0 <= nx && nx < C) && (0 <= ny && ny < R) && map[nx, ny] == '.')
                    {
                        map[nx, ny] = '#';
                        tq.Enqueue(Tuple.Create(nx, ny, step + 1));
                    }
                }
            }
        }
    }
}
