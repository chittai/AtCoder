using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC145
{
    class C
    {
        static decimal total = 0;
        static long[] x;
        static long[] y;

        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());
            x = new long[N];
            y = new long[N];

            for (long i = 0; i < N; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                x[i] = input[0];
                y[i] = input[1];
            }

            //DFS : for(i 0-N)
            //一度でも登場したノードは無視する必要がある
            decimal sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    List<long> list = new List<long>();
                    for (int k = 0; k < list.Count; k++)
                    {
                        list.Add(k);
                    }
                    if (i != j)
                    {
                        //Console.WriteLine("-------");
                        //Console.WriteLine("{0} {1}", i, j);
                        DFS(i, j, list, sum);
                    }

                }
            }

            decimal n = N;
            decimal z = 1;
            while (0 < n)
            {
                z *= n;
                n--;
            }
            //Console.WriteLine(z);
            Console.WriteLine(total / (decimal)z);
        }

        static void DFS(long beforeIndex, long nowIndex, List<long> list, decimal sum)
        {
            //total += Math.Sqrt(Math.Pow(x[nowIndex] - x[beforeIndex], 2) + Math.Pow(y[nowIndex] - y[beforeIndex], 2));

            sum += (decimal)Math.Sqrt((x[nowIndex] - x[beforeIndex]) * (x[nowIndex] - x[beforeIndex]) + (y[nowIndex] - y[beforeIndex]) * (y[nowIndex] - y[beforeIndex]));

            List<long> tempList = list;
            //前のノードとの距離を求める。それを足す。末端まで足した時の合計が１パターンとして扱える
            //一つの変数にすべてのノード間の距離の値を足して、最後にN!で割る

            //Console.WriteLine("{0}, {1}, {2}", beforeIndex, nowIndex, sum);
            //Console.WriteLine(string.Join(",", tempList));

            if (tempList.Contains(beforeIndex)) tempList.Remove(beforeIndex);
            if (tempList.Contains(nowIndex)) tempList.Remove(nowIndex);

            if (tempList.Count == 0) total += (decimal)sum;

            //if (tempList.Count == 0) return;
            //if (list.Count == 0) return;


            for (int i = 0; i < tempList.Count; i++)
            {
                DFS(nowIndex, tempList[i], tempList, sum);
            }
        }
        //注意点として、一度でも通過したノードはもうカウントしない
        //nowIndexの値を削ったlistを引数にする
    }
}

