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

            int N = int.Parse(Console.ReadLine());
            int[] D = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long MOD = 998244353;
            long[] DCount = new long[N];

            //エラー処理
            if (D[0] != 0) { Console.WriteLine(0); return; }
            if (N <= D.Max()) { Console.WriteLine(0); return; }
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
            //Console.WriteLine(string.Join(",", DCount));

            long parent = 1;
            for (int i = 1; i < N; i++)
            {
                if (0 < DCount[i])
                {
                    for (int j = 0; j < DCount[i]; j++)
                    {
                        parent = (parent * DCount[i - 1]) % MOD;
                    }
                }
            }

            Console.WriteLine(parent);

        }
    }
}