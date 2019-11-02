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
            int Bsum = B.Where(b => Amax < b).Sum();
            /*
            for (int i = 0; i < N; i++)
            {
                if (Amax < B[i])
                {
                    count++;
                    Bsum += B[i];
                }
            }
             */

            //(H-Bsum) / A で割り切れたら,この値にBsumに使用した値の数を足したらOK
            //割り切れなかったら＋1をする。

            if ((H - Bsum) % Amax == 0) { Console.WriteLine(Bcount + ((H - Bsum) / Amax)); }
            else { Console.WriteLine(Bcount + 1 + ((H - Bsum) / Amax)); }


        }
    }
}
