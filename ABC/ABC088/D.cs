using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC088
{
    class D
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];
            int[,] s = new int[W, H];
            int scount = 0;

            for (int h = 0; h < H; h++)
            {
                string S = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    s[w, h] = S[w];
                    if (S[w] == '#') scount++;
                }
            }

            Queue<Tuple<int, int, int>> q = new Queue<Tuple<int, int, int>>();

            int step = 0;
            q.Enqueue(Tuple.Create(0, 0, step));
            s[0, 0] = '#';

            int[] vx = { 0, 1, 0, -1 };
            int[] vy = { 1, 0, -1, 0 };

            while (0 < q.Count)
            {

                var tq = q.Dequeue();
                int x = tq.Item1;
                int y = tq.Item2;
                step = tq.Item3;

                if (x == W - 1 && y == H - 1)
                {
                    Console.WriteLine(H * W - scount - step - 1);
                    return;
                }

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + vx[i];
                    int ny = y + vy[i];
                    if ((0 <= nx && nx < W) && (0 <= ny && ny < H) && s[nx, ny] == '.')
                    {
                        s[nx, ny] = '#';
                        q.Enqueue(Tuple.Create(nx, ny, step + 1));
                    }
                }
            }
            Console.WriteLine(-1);
        }
    }
}
