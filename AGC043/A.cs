using System;
using System.Linq;


namespace AGC043
{
    class A
    {
        static int H;
        static int W;
        static char[][] map;
        static int res;
        static void Main(string[] args)
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            H = HW[0];
            W = HW[1];
            res = int.MaxValue;
            map = Enumerable.Repeat(0, H).Select(_ => Console.ReadLine().ToCharArray()).ToArray();

            dfs(0, 0, 0);

            Console.WriteLine(res);
        }

        // h , w -> 0 ~ 99 H,W -> 2 
        // conflg , 1 -> 連続している, 0 -> 連続していない
        static void dfs(int h, int w, int count)
        {

            if (h == H - 1 && w == W - 1) { res = Math.Min(res, count); }

            if (h == 0 && w == 0 && map[h][w] == '#' && map[h + 1][w] == '.' && map[h][w + 1] == '.')
            {
                count++;
            }

            var tmph = h;
            var tmpw = w;
            // 右にしろ下にしろ、＃だったらワープさせれば良い
            if (h + 1 < H && map[h + 1][w] == '#')
            {
                tmph = h;
                tmpw = w;
                while (tmph + 1 < H && map[tmph + 1][tmpw] == '#') { tmph++; }
                while (tmpw + 1 < W && map[tmph][tmpw + 1] == '#') { tmpw++; }
                dfs(tmph, tmpw, count + 1);
            }

            if (w + 1 < W && map[h][w + 1] == '#')
            {
                tmph = h;
                tmpw = w;
                while (tmpw + 1 < W && map[tmph][tmpw + 1] == '#') { tmpw++; }
                while (tmph + 1 < H && map[tmph + 1][tmpw] == '#') { tmph++; }
                dfs(tmph, tmpw, count + 1);
            }
            if (h + 1 < H && map[h + 1][w] == '.') dfs(h + 1, w, count); // 下
            if (w + 1 < W && map[h][w + 1] == '.') dfs(h, w + 1, count); // 下
        }
    }
}
