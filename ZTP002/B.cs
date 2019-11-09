using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ZTP002
{
    class B
    {
        static void Main(string[] args)
        {

            //StreamReader sr = new StreamReader(@"./test");
            //int N = int.Parse(sr.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[] D = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] D = sr.ReadLine().Split().Select(int.Parse).ToArray();
            long MOD = 998244353;

            //頂点1からの距離で何個あるのか分類する
            long[] DCount = new long[N];

            //エラー処理
            if (N <= D.Max()) { Console.WriteLine(0); return; }
            if (D[0] != 0) { Console.WriteLine(0); return; }
            var Dsorted = D.OrderBy(x => x).ToArray();
            for (int i = 0; i < N - 1; i++)
            {
                if (i < N - 1 && Dsorted[i] + 2 <= Dsorted[i + 1]) { Console.WriteLine(0); return; }
            }
            if (1 < D.Count(x => x == 0)) { Console.WriteLine(0); return; }

            for (int i = 0; i < N; i++)
            {
                DCount[D[i]]++;
            }

            //先頭から木の組み合わせを作りつつ、Pow(parent, children)をかけ合わせる
            long parent = 1;
            for (int i = 1; i < N; i++)
            {
                if (DCount[i] != 0) parent = (parent * (long)Math.Pow(DCount[i - 1], DCount[i]) % MOD) % MOD;
            }

            //Console.WriteLine(string.Join(",", DCount));
            Console.WriteLine(parent);

        }
    }
}
