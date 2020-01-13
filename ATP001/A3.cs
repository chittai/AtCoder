using System;
using System.Collections.Generic;
using System.Linq;

namespace ATP001
{
    class A3
    {
        static int X;
        static int Y;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            X = input[1];
            Y = input[0];

            char[,] map = new char[X, Y];
            int sx = 0;
            int sy = 0;
            for (int y = 0; y < Y; y++)
            {
                string s = Console.ReadLine();
                for (int x = 0; x < X; x++)
                {
                    map[x, y] = s[x];
                    if (s[x] == 's') { sx = x; sy = y; }
                }
            }

            bool res = GridDFS(sx, sy, map);

            if (res) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        static bool GridDFS(int sx, int sy, char[,] map)
        {
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            Tuple<int, int> ts = Tuple.Create(sx, sy);
            stack.Push(ts);
            bool isOK = false;

            int[] vx = { 0, 1, 0, -1 };
            int[] vy = { 1, 0, -1, 0 };
            while (0 < stack.Count)
            {
                var t = stack.Pop();
                int x = t.Item1;
                int y = t.Item2;
                if (map[x, y] == 'g') { isOK = true; break; }
                map[x, y] = '#';

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + vx[i];
                    int ny = y + vy[i];

                    if ((0 <= nx && nx < X) && (0 <= ny && ny < Y) && map[nx, ny] != '#')
                    {
                        stack.Push(Tuple.Create(x + vx[i], y + vy[i]));
                    }
                }
            }
            return isOK;
        }

    }
}
