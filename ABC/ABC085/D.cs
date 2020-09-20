using System;
using System.Linq;

namespace ABC085
{
    class D
    {
        static void Main(string[] args)
        {
            //入力
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int H = input[1];

            int[] A = new int[N];
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[i] = input[0];
                B[i] = input[1];
            }
            //A & B をソートする(dec)
            A = A.OrderByDescending(x => x).ToArray();
            B = B.OrderByDescending(x => x).ToArray();

            //Aの最大値を求める。その最大値以上のBの値の合計(Bsum)を求める
            int Amax = A[0];
            int Bcount = B.Count(b => Amax < b);

            //HからAmax < B[i] となる値を順に引いていく。0以下になったらそこまでの回数が回答
            //0以下にならなかった場合に限り、その値をAmaxで割る。割り切れなかったら回答に+1をする
            for (int i = 0; i < Bcount; i++)
            {
                H -= B[i];
                if (H <= 0) { Console.WriteLine(i + 1); return; }
            }

            int res = H / Amax;
            if (H % Amax == 0) Console.WriteLine(res + Bcount);
            else Console.WriteLine(res + Bcount + 1);
        }
    }
}
