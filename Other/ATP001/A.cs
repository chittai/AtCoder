using System;
using System.Collections.Generic;
using System.Linq;

namespace ATP001
{
    class A
    {
        static char[,] c;
        static bool isOK;
        static int H;
        static int W;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            H = input[0];
            W = input[1];

            c = new char[W, H];
            int sx = 0;
            int sy = 0;
            for (int h = 0; h < H; h++)
            {
                string s = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    c[w, h] = s[w];
                    if (s[w] == 's') { sx = w; sy = h; }
                }
            }

            DFS(sx, sy);

            if (isOK) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        static void DFS(int x, int y)
        {
            if (c[x, y] == '#') { return; }
            else if (c[x, y] == 'g') { isOK = true; }

            if (isOK) { return; }

            c[x, y] = '#';

            if (x + 1 < W) DFS(x + 1, y);
            if (0 <= x - 1) DFS(x - 1, y);
            if (y + 1 < H) DFS(x, y + 1);
            if (0 <= y - 1) DFS(x, y - 1);

        }
    }
}
