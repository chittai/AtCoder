using System;
using System.Linq;
using System.Collections.Generic;

namespace AGC032
{
    class Program
    {
        static void Main(string[] args)
        {
            // input, N ,List<int> b 
            //for N -> 1 
            //各処理時点において、1 <= j <= i を満たす要素が存在するのか確認する
            //添字と要素の数が一致しているかどうか

            int N = int.Parse(Console.ReadLine());
            List<int> b = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (b[0] != 1) { Console.WriteLine(-1); return; }

            int[] Res = new int[N];
            int index = 0;
            for (int i = N; i >= 1; i--)
            {
                bool isOK = false;
                for (int j = 0; j < b.Count; j++)
                {
                    //条件を満たすものが複数ある場合は、一番大きいものを選ぶ
                    if (b[j] == j + 1)
                    {
                        isOK = true;
                        index = Math.Max(index, j);
                    }
                }
                if (!isOK) { Console.WriteLine(-1); return; }

                Res[i - 1] = index + 1;
                b.RemoveAt(index);
                index = 0;
            }

            foreach (var i in Res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
