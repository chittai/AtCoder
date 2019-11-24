using System;
using System.Linq;

namespace DDCC2020
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long H = input[0];
            long W = input[1];
            long K = input[2];

            long[] countArray = new long[H];
            char[,] s = new char[W, H];
            for (int h = 0; h < H; h++)
            {
                string S = Console.ReadLine();
                long count = 0;
                for (int w = 0; w < W; w++)
                {
                    s[w, h] = S[w];
                    if (S[w] == '#') count++;
                }
                countArray[h] = count;
            }

            long num = 1;
            long[,] res = new long[W, H];
            //行に1個以上のいちごがある場合
            for (int h = 0; h < H; h++)
            {
                bool isFirst = true;
                if (countArray[h] != 0)
                {
                    for (int w = 0; w < W; w++)
                    {
                        if (s[w, h] == '#')
                        {
                            if (!isFirst) { num++; }
                            if (isFirst) { isFirst = false; }
                        }
                        res[w, h] = num;
                    }
                    num++;
                }
            }
            //行にいちごがない場合
            for (int h = 0; h < H; h++)
            {
                if (h == 0 && countArray[h] == 0)
                {
                    for (int h2 = h; h2 < H; h2++)
                    {
                        if (countArray[h2] != 0)
                        {
                            for (int w = 0; w < W; w++)
                            {
                                res[w, h] = res[w, h2];
                            }
                            break;
                        }
                    }
                }

                if (0 < h && countArray[h] == 0)
                {
                    for (int w = 0; w < W; w++)
                    {
                        res[w, h] = res[w, h - 1];
                    }
                }
            }

            //output
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    Console.Write(res[w, h]);
                    if (w < W - 1) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
