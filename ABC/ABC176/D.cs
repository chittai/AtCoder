using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC176
{
    class Program
    {

        static char[,] map;

        static void Main(string[] args)
        {
            //var NXT = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //var N = long.Parse(Console.ReadLine());
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            var HW = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var H = HW[0]; var W = HW[1];
            var C = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var Ch = C[0]; var Cw = C[1];
            var D = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var Dh = D[0]; var Dw = D[1];

            for (int h = 0; h < H; h++)
            {
                var row = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    map[h, w] = row[w];
                }
            }

            var dp = new long[H, W];
            dp[Ch, Cw] = 0;
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    dp[H, w] = int.MaxValue;
                }
            }


            var dh = new int[] { 0, 1, 0, -1 };
            var dw = new int[] { 1, 0, -1, 0 };
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        for (int j = 1; j <= 2; j++)
                        {
                            for (int k = 0; i < 4; i++)
                            {

                            }
                        }
                    }
                }
            }
        }
    }
}
