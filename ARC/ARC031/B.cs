using System;
using System.Linq;

namespace ARC031
{
    class B
    {
        static char[][] map;
        static int num;
        static void Main(string[] args)
        {
            //init
            map = Enumerable.Repeat(0, 10).Select(_ => Console.ReadLine().ToCharArray()).ToArray();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (map[i][j] == 'o') { num++; dfs(i, j); }
                }
            }

            int[] vx = { 1, 0, -1, 0 };
            int[] vy = { 0, 1, 0, -1 };
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //var count = 0;
                    var sum = "";
                    for (int k = 0; k < 4; k++)
                    {
                        if (0 <= i + vx[k] && i + vx[k] < 10 && 0 <= j + vy[k] && j + vy[k] < 10 && map[i + vx[k]][j + vy[k]] != 'x') sum += map[i + vx[k]][j + vy[k]];
                    }
                    //var sumarray = sum.OrderBy(x => x).ToArray().Distinct();
                    var sum2 = sum.ToCharArray().Distinct().ToArray();

                    if (sum2.Length == num) { Console.WriteLine("YES"); return; };
                }
            }
            Console.WriteLine("NO");
        }

        static void dfs(int x, int y)
        {
            if (map[x][y] != 'o') return;
            map[x][y] = (char)(num + '0');
            int[] vx = { 1, 0, -1, 0 };
            int[] vy = { 0, 1, 0, -1 };
            for (int j = 0; j < 4; j++)
            {
                if (0 <= x + vx[j] && x + vx[j] < 10 && 0 <= y + vy[j] && y + vy[j] < 10) dfs(x + vx[j], y + vy[j]);
            }
        }
    }
}
