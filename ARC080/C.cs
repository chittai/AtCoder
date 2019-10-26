using System;
using System.Linq;

namespace ARC080
{
    class C
    {
        static void Main(string[] args)
        {
            /*
            方針：
            N%4 == 0 となる値が N/2 個以上あるかどうか。
            2が2個あることで4の倍数になるので、2の数も数える。
            2が2個で4の倍数1個と同じ

            メモ：2は隣り合っている間は4の倍数になる。奇数偶数に依らない

            新方針：
            2の数をNから引いて、残りの値にたいして4の倍数でジャッジする
            　→2の数だけではだめ。2の倍数同士でも4の倍数にできるので、2の倍数から4の倍数を引いた数で計算するべき
            */

            //入力
            long N = long.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

            //N%4 == 0 となる値を格納する変数
            int count = 0;
            //2の数
            int secondcount = 0;

            //aを最初からチェックする。4の倍数のときcount++する
            for (int i = 0; i < N; i++)
            {
                if (a[i] % 4 == 0) { count++; }
                if (a[i] % 2 == 0) { secondcount++; }
            }

            secondcount -= count;

            //2の数が2以上の時、Nから引く。
            if (2 <= secondcount)
            {
                N -= secondcount;
                //Nが奇数になった場合、N / 2に1を足す
                //Nが偶数のときはそのまま
                if (N % 2 != 0)
                {
                    if ((N / 2) + 1 <= count) { Console.WriteLine("Yes"); }
                    else Console.WriteLine("No");
                    return;
                }
                else if (N / 2 <= count) { Console.WriteLine("Yes"); }
                else Console.WriteLine("No");
            }
            else
            {
                if (N / 2 <= count) { Console.WriteLine("Yes"); }
                else Console.WriteLine("No");
            }
        }
    }
}
