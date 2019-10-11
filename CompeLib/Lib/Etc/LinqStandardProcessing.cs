/* AtCoderで使用する定番のLinqの処理をまとめる */

using System;
using System.Linq;

namespace Etc
{
    class LinqStandardProcessing
    {
        static void Main(string[] args)
        {

            // 数の処理に使用 
            int N;
            int[] NA;
            int a;
            int b;
            // 文字列の処理に使用
            string S;

            /* 以下、処理のまとめ */

            // 数列を入力して、文字列から整数へと変換する
            NA = Console.ReadLine().Select(int.Parse).ToArray();

            // 違う用途の数列を入力して各対応する変数に格納する
            NA = Console.ReadLine().Split().Select(int.Parse).ToArray();
            a = NA[0];
            b = NA[1];

            // 配列の要素数をカウントする
            // Count には条件を指定できる
            N = Console.ReadLine().Count(x => x == 'o');

            // Linqで処理した結果文字列へ変換する
            // 下記は、Linqを使用したインデックス処理も併せて記載している
            S = new string(Console.ReadLine().Where((x, index) => index % 2 == 0).ToArray());
        }
    }
}