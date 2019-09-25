using System;

namespace ABC075
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            int[,] S = new int[H, W];
            string s = "";
            for (int i = 0; i < H; i++)
            {
                s = Console.ReadLine();
                for (int j = 0; j < W; j++)
                {
                    if (s[j] == '.') S[i, j] = 0;
                    if (s[j] == '#') S[i, j] = -1;
                }
            }

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (0 <= S[i, j])
                    {
                        // 上下
                        if (0 <= i - 1 && S[i - 1, j] == -1) S[i, j]++;
                        if (i + 1 < H && S[i + 1, j] == -1) S[i, j]++;

                        // 左右
                        if (j + 1 < W && S[i, j + 1] == -1) S[i, j]++;
                        if (0 <= j - 1 && S[i, j - 1] == -1) S[i, j]++;

                        // 右上、右下
                        if (j + 1 < W && 0 <= i - 1 && S[i - 1, j + 1] == -1) S[i, j]++;
                        if (j + 1 < W && i + 1 < H && S[i + 1, j + 1] == -1) S[i, j]++;

                        // 左上、左下
                        if (0 <= j - 1 && 0 <= i - 1 && S[i - 1, j - 1] == -1) S[i, j]++;
                        if (0 <= j - 1 && i + 1 < H && S[i + 1, j - 1] == -1) S[i, j]++;
                    }
                }
            }

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (S[i, j] == -1) Console.Write('#');
                    else Console.Write(S[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
