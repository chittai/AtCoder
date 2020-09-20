using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AGC033
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];

            // "0" の時が白('.')、"1"の時が黒('#')
            int[,] A = new int[H, W];
            string S;

            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

            for (int i = 0; i < H; i++)
            {
                S = Console.ReadLine();
                //S = sr.ReadLine();
                for (int j = 0; j < W; j++)
                {
                    A[i, j] = (S[j] == '.' ? 0 : 1);
                    if (A[i, j] == 1) q.Enqueue(Tuple.Create(i, j));
                }
            }

            int conut = 0;
            bool isChange = false;
            int len = q.Count;
            Tuple<int, int> t;

            while (q.Count > 0)
            {
                t = q.Dequeue();
                int h = t.Item1;
                int w = t.Item2;

                int u = t.Item1 - 1;
                int d = t.Item1 + 1;
                int l = t.Item2 - 1;
                int r = t.Item2 + 1;

                // 上
                if (0 <= u && A[u, w] == 0)
                {
                    A[u, w] = 1;
                    q.Enqueue(Tuple.Create(u, w));
                    isChange = true;
                }

                // 下
                if (d < H && A[d, w] == 0)
                {
                    A[d, w] = 1;
                    q.Enqueue(Tuple.Create(d, w));
                    isChange = true;
                }

                // 左
                if (0 <= l && A[h, l] == 0)
                {
                    A[h, l] = 1;
                    q.Enqueue(Tuple.Create(h, l));
                    isChange = true;
                }

                // 右
                if (r < W && A[h, r] == 0)
                {
                    A[h, r] = 1;
                    q.Enqueue(Tuple.Create(h, r));
                    isChange = true;
                }

                len--;
                if (len == 0 && isChange) { conut++; len = q.Count; isChange = false; }
            }

            Console.WriteLine(conut);
        }
    }
}
