using System;

namespace ABC096
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            char[,] c = new char[H, W];
            string s;
            for (int i = 0; i < H; i++)
            {
                s = Console.ReadLine();
                for (int j = 0; j < W; j++)
                {
                    c[i, j] = s[j];
                }
            }

            bool isOneOK = true;
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (c[i, j] == '#')
                    {
                        if (
                            (i + 1 < H && c[i + 1, j] != '#')
                            && (0 <= i - 1 && c[i - 1, j] != '#')
                            && (j + 1 < W && c[i, j + 1] != '#')
                            && (0 <= j - 1 && c[i, j - 1] != '#')
                            ) { isOneOK = false; }
                    }
                }
            }

            if (isOneOK) { Console.WriteLine("Yes"); } else { Console.WriteLine("No"); }

        }
    }
}
