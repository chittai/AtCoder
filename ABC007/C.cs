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

            string[] map = new string[R];
            for (int i = 0; i < R; i++)
            {
                map[i] = Console.ReadLine();
            }

            Queue<int> q = new Queue<int>();

            q.Enqueue(sy);
            q.Enqueue(sx);

            int step = 0;
            q.Enqueue(step);

            while (0 < q.Count)
            {
                int y = q.Dequeue();
                int x = q.Dequeue();
                step = q.Dequeue();

                if (y == gy && x == gx)
                {
                    Console.WriteLine(step);
                    break;
                }

                if (0 < y && 0 < x)
                {
                    if (map[y + 1][x] == '.') { q.Enqueue(y + 1); q.Enqueue(x); q.Enqueue(step + 1); }
                    if (map[y - 1][x] == '.') { q.Enqueue(y - 1); q.Enqueue(x); q.Enqueue(step + 1); }
                    if (map[y][x + 1] == '.') { q.Enqueue(y); q.Enqueue(x + 1); q.Enqueue(step + 1); }
                    if (map[y][x - 1] == '.') { q.Enqueue(y); q.Enqueue(x - 1); q.Enqueue(step + 1); }

                    map[sy] = CharSwap(map[sy], sx);
                }
            }
        }
        static string CharSwap(string s, int x)
        {
            char[] c = s.ToCharArray();
            c[x] = '#';

            string cs = new string(c);
            return cs;
        }
    }
}
