using System;

namespace AGC006
{
    class A
    {

        /* 
        今回は、実験的に、処理についてコメントを残す
        まずはコードを書く前の言語化と、コードを書いている時に気になったことなどをメモとして残しておく
        */


        static void Main(string[] args)
        {
            // 入力処理
            int N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            //s==tの場合の処理
            //sとtが一部同じ時の処理
            //sに対して、tを→にずらしていく。それらがマッチした時の添字情報がほしい
            //s[i]- s[s.length](0 < i)に対して、t[0]-t[t.length -1 -i]を比較する
            //マッチしていたときの添字iに対してs+t-(t.length - i )

            //for
            //sとｔの部分一致があるか調べる処理
            //sはs[i]- s[s.length](0 < i)の範囲
            //t はt[0]-t[t.length -1 -i]を比較する
            //一致した時点で処理する。
            //最後までみて一致していないときはs+t
            for (int i = 0; i < s.Length; i++)
            {
                //substringで比較する
                string spart = s.Substring(i, s.Length - i); //最後の文字が判定できるか確認が必要
                string tpart = t.Substring(0, s.Length - i);

                //部分一致したか判定する
                if (spart == tpart) { Console.WriteLine(s.Length + t.Length - (s.Length - i)); return; }
            }
            Console.WriteLine(s.Length + t.Length);
        }
    }
}