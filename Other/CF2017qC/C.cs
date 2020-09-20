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
            var s = Console.ReadLine().ToList();

            int count = 0;
            //sが空になるまで
            while (0 < s.Count)
            {
                //先頭と末尾をチェックする
                //先頭と末尾が同じ場合
                if (s[0] == s[s.Count - 1])
                {
                    ////先頭と末尾の文字を削除する
                    s.RemoveAt(0);
                    if (0 < s.Count) s.RemoveAt(s.Count - 1);
                }
                else if (s[0] != s[s.Count - 1])
                {
                    //先頭と末尾が異なっており、両方ともxではない場合は-1を出 
                    //先頭と末尾が異なっており、片方がxの場合はメイン処理
                    ////末尾がxの場合はxを先頭へ追加
                    ////先頭がxの場合はxを末尾へ追加
                    if (s[0] != 'x' && s[s.Count - 1] != 'x')
                    {
                        Console.WriteLine(-1); return;
                    }
                    else if (s[0] != 'x')
                    {
                        s.Insert(0, 'x');
                        count++;
                    }
                    else if (s[s.Count - 1] != 'x')
                    {
                        s.Add('x');
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
