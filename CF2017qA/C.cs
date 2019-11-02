using System;
using System.Linq;

namespace CF2017qA
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];

            char[,] HW = new char[H, W];
            int[] cCount = new int[26];
            for (int h = 0; h < H; h++)
            {
                string a = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    HW[h, w] = a[w];
                    //行列に出てくる文字の数を数える
                    cCount[a[w] - 'a']++;
                }
            }

            //hwのパリティを確認する
            //両方とも偶数
            if (H % 2 == 0 && W % 2 == 0)
            {
                for (int i = 0; i < cCount.Length; i++)
                {
                    if (cCount[i] % 4 != 0) { Console.WriteLine("No"); return; }
                }
                Console.WriteLine("Yes"); return;
            }

            //両方が奇数
            if (H % 2 != 0 && W % 2 != 0)
            {
                for (int i = 0; i < cCount.Length; i++)
                {
                    cCount[i] %= 4;
                }

                int ecount = 0;
                int ocount = 0;
                for (int i = 0; i < cCount.Length; i++)
                {
                    if (cCount[i] != 0 && cCount[i] % 2 == 0) ecount++;
                    else if (cCount[i] % 2 != 0) ocount++;
                }

                if (ecount < (W + H) / 2 && ocount == 1)
                {
                    Console.WriteLine("Yes"); return;
                }
                else
                {
                    Console.WriteLine("No"); return;
                }
            }

            //片方が奇数
            if (H % 2 == 0 || W % 2 == 0)
            {
                //eo/oeのときは、文字がでてくる数から4で割った余りを計算して、2の倍数であればOK
                //残っている値が空白のマスの数よりも大きくなったらNG
                for (int i = 0; i < cCount.Length; i++)
                {
                    cCount[i] %= 4;
                }

                int count = 0;
                for (int i = 0; i < cCount.Length; i++)
                {
                    if (cCount[i] != 0 && cCount[i] % 2 == 0) count++;
                    else if (cCount[i] % 2 != 0) { Console.WriteLine("No"); return; }
                }

                if (H % 2 == 0 && count <= H / 2)
                {
                    Console.WriteLine("Yes"); return;
                }
                else if (W % 2 == 0 && count <= W / 2)
                {
                    Console.WriteLine("Yes"); return;
                }
                else
                {
                    Console.WriteLine("No"); return;
                }
            }
        }
    }
}
