using System;
using System.Linq;
using System.Collections.Generic;

namespace KPC2019
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] B = Console.ReadLine().Split().Select(long.Parse).ToArray();

            //Aの総和がBよりもどうなっているか
            if (A.Sum() < B.Sum())
            {
                //小さい
                ///-1を出力
                Console.WriteLine(-1); return;
            }
            else
            {
                //大きい
                ////メイン処理を書く
                ////N繰り返して、BとAの差分を調べる O(N)
                ////aとbのリストを作成する
                List<long> a = new List<long>();
                List<long> b = new List<long>();
                for (long i = 0; i < N; i++)
                {
                    if (A[i] < B[i]) b.Add(Math.Abs(B[i] - A[i])); // 不足
                    else if (B[i] < A[i]) a.Add(Math.Abs(A[i] - B[i]));  // 余り
                }

                if (b.Count == 0) { Console.WriteLine(0); return; }

                ////bの要素分繰り返す。最大でもO(N)
                a = a.OrderByDescending(x => x).ToList();
                long bsum = b.Sum();
                long asum = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    asum += a[i];
                    if (bsum < asum) { Console.WriteLine(b.Count + i + 1); return; }
                }
                //Console.WriteLine(0);
            }
        }
    }
}
