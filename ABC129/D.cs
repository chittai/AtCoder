using System;
using System.Linq;

namespace ABC129
{
    class D
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int H = input[0];
            int W = input[1];

            string[] S = new string[H];
            for (int i = 0; i < H; i++)
            {
                S[i] = Console.ReadLine();
            }

            int[,] L = new int[H, W];
            int[,] R = new int[H, W];
            int[,] U = new int[H, W];
            int[,] D = new int[H, W];

            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    if (S[h][w] == '#') { L[h, w] = 0; }
                    else if (w == 0) { L[h, w] = 1; }
                    else if (0 < w) { L[h, w] = L[h, w - 1] + 1; }
                }

                for (int w = W - 1; w >= 0; w--)
                {
                    if (S[h][w] == '#') { R[h, w] = 0; }
                    else if (w == W - 1) { R[h, w] = 1; }
                    else if (w < W - 1) { R[h, w] = R[h, w + 1] + 1; }
                }

            }

            for (int w = 0; w < W; w++)
            {
                for (int h = 0; h < H; h++)
                {
                    if (S[h][w] == '#') { D[h, w] = 0; }
                    else if (h == 0) { D[h, w] = 1; }
                    else if (0 < h) { D[h, w] = D[h - 1, w] + 1; }
                }

                for (int h = H - 1; h >= 0; h--)
                {
                    if (S[h][w] == '#') { U[h, w] = 0; }
                    else if (h == H - 1) { U[h, w] = 1; }
                    else if (h < H - 1) { U[h, w] = U[h + 1, w] + 1; }
                }
            }

            int[,] Res = new int[H, W];
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    Res[i, j] = L[i, j] + R[i, j] + U[i, j] + D[i, j] - 3;
                }
            }

            int max = 0;
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    max = Math.Max(max, Res[i, j]);
                }
            }
            Console.WriteLine(max);
        }
    }
}