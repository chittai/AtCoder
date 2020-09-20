using System;

namespace ARC029
{
    class A
    {
        static void Main(string[] args)
        {

            //N個の肉の部分集合一覧を求める
            //各部分集合で時間を計測し、最もかかる時間が短い部分集合の値が答え
            //bit全探索で実装する

            //input
            int N = int.Parse(Console.ReadLine());
            int[] t = new int[N];
            for (int i = 0; i < N; i++)
            {
                t[i] = int.Parse(Console.ReadLine());
            }

            //1 << 4 のパターン
            //bit & (1 << i(i:0-3)) で 0 の時と1の時で分けて計算する
            //計算して、大きい方の値を選択する
            int res = int.MaxValue;
            for (int bit = 0; bit < (1 << N); bit++)
            {
                int total = 0;
                int t1 = 0;
                int t2 = 0;
                for (int i = 0; i < N; i++)
                {
                    if ((bit & (1 << i)) > 0)
                    {
                        t1 += t[i];
                    }
                    else
                    {
                        t2 += t[i];
                    }
                }
                total = Math.Max(t1, t2);
                res = Math.Min(res, total);
            }
            Console.WriteLine(res);
        }
    }
}
