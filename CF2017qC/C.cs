using System;
using System.Linq;
using System.Collections.Generic;

namespace CF2017qC
{
    class C
    {
        static void Main(string[] args)
        {
            //入力 s
            string s = Console.ReadLine();
            //sからxを抜いた文字列を配列として格納
            List<char> S = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'x') S.Add(s[i]);
            }

            //s.lengthが1かどうか
            if (S.Count <= 1)
            {
                //0を出力
                Console.WriteLine(0);
            }
            else
            {
                //2以上の時
                //0->と←s.length-1で (s.length-1)/2まで要素を比較する→奇数用に切り上げる
                //同じであれば続けて、違ったら回分じゃないので終了(-1を出力)
                for (int i = 0; i < S.Count / 2; i++)
                {
                    if (S[i] != S[S.Count - 1]) { Console.WriteLine(-1); return; }
                }

                int count = 0; //操作回数を数える
                //入力された文字列をそのまま使い、

                Console.WriteLine();
            }
        }
    }
}
