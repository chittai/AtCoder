using System;
using System.Linq;

namespace AGC007
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];
            char[,] A = new char[W, H];
            for (int h = 0; h < H; h++)
            {
                string s = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    A[w, h] = s[w];
                }
            }

            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    if (0 < w && 0 < h && A[w, h] == '#' && (A[w - 1, h] == '#' && A[w, h - 1] == '#'))
                    {
                        Console.WriteLine("Impossible");
                        return;
                    }

                    if (w < W - 1 && h < H - 1 && A[w, h] == '#' && (A[w + 1, h] == '#' && A[w, h + 1] == '#'))
                    {
                        Console.WriteLine("Impossible");
                        return;
                    }
                }
            }
            Console.WriteLine("Possible");
        }
    }
}
