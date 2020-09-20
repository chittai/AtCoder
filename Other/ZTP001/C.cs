using System;
using System.Linq;
using System.Collections.Generic;

namespace ZTP001
{
    class C
    {
        static void Main(string[] args)
        {
            //入力
            int N = int.Parse(Console.ReadLine());

            //各値の和とインデックス情報を持つ配列 Tuple<sum,index>
            Tuple<int, int>[] res = new Tuple<int, int>[N];
            //A,B
            int[] A = new int[N];
            int[] B = new int[N];

            //sumの計算をする
            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[i] = input[0];
                B[i] = input[1];
                res[i] = Tuple.Create(i, A[i] + B[i]);
            }

            //和の値で降順でソートする
            var res2 = res.OrderByDescending(x => x.Item2);

            //ソートされたデータからインデックスの情報を取り出して、
            //高橋くんのときは奇数番目のA[i]をたす。青木くんのときは偶数番目のB[i]を引く
            long count = 0;
            int index = 0;
            foreach (var i in res2)
            {
                if (index % 2 == 0) count += A[i.Item1];
                else count -= B[i.Item1];
                index++;
            }

            Console.WriteLine(count);
        }
    }
}
