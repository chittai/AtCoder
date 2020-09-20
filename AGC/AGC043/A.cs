using System;
using System.Linq;


namespace AGC043
{
    class A
    {
        static int H;
        static int W;
        static char[][] map;
        static int[,] dp;
        static void Main(string[] args)
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            H = HW[0]; W = HW[1];
            map = Enumerable.Repeat(0, H).Select(_ => Console.ReadLine().ToCharArray()).ToArray();
            dp = new int[H, W];
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    dp[h, w] = int.MaxValue;
                }
            }

            if (map[0][0] == '#') dp[0, 0] = 1;
            else dp[0, 0] = 0;


            var dh = new int[] { 0, 1 };
            var dw = new int[] { 1, 0 };
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int nh = h + dh[i]; int nw = w + dw[i];
                        if (H <= nh || W <= nw) continue;
                        int add = 0;
                        if (map[nh][nw] == '#' && map[h][w] == '.') add = 1;
                        dp[nh, nw] = Math.Min(dp[nh, nw], dp[h, w] + add);
                    }

                }
            }
            Console.WriteLine(dp[H - 1, W - 1]);
        }
    }
}
