using System;

namespace ABC049
{
    class C
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            //入力された文字列を反転させる
            string rs = Reverse(s);

            //指定があった4つの文字列を反転させて配列化する
            string[] input = { "dream", "erase", "eraser", "dreamer" };
            for (int i = 0; i < 4; i++)
            {
                input[i] = Reverse(input[i]);
            }

            //前から4つの中のどれかが対応しているか確認する
            int count = 0;
            for (int i = 0; i < rs.Length;)
            {
                count = i;
                for (int j = 0; j < 4; j++)
                {
                    if ((i + input.Length) > rs.Length) { }
                    if (rs.Substring(i, input[j].Length) == input[j])
                    {
                        i += input[j].Length;
                        break;
                    }
                }

                if (i == count)
                {
                    Console.WriteLine("NO");
                    return;
                }

            }
            Console.WriteLine("YES");
            return;
        }

        static string Reverse(string s)
        {
            Char[] c = s.ToCharArray();
            Array.Reverse(c);
            string rs = new string(c);
            return rs;
        }
    }
}
