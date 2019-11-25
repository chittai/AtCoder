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
            while (0 < tq.Count)
            {
                var q = tq.Dequeue();
                int x = q.Item1;
                int y = q.Item2;
                step = q.Item3;


                //Console.WriteLine("y : " + y);
                //Console.WriteLine("x : " + x);
                //Console.WriteLine("step : " + step);

                if (x == gx && y == gy)
                {
                    Console.WriteLine(step);
                    return;
                }

                if (y + 1 < R && map[x, y + 1] == '.') { map[x, y + 1] = '#'; tq.Enqueue(Tuple.Create(x, y + 1, step + 1)); }
                if (0 <= y - 1 && map[x, y - 1] == '.') { map[x, y - 1] = '#'; tq.Enqueue(Tuple.Create(x, y - 1, step + 1)); }
                if (x + 1 < C && map[x + 1, y] == '.') { map[x + 1, y] = '#'; tq.Enqueue(Tuple.Create(x + 1, y, step + 1)); }
                if (0 < x - 1 && map[x - 1, y] == '.') { map[x - 1, y] = '#'; tq.Enqueue(Tuple.Create(x - 1, y, step + 1)); }
            }
        }
    }
}
