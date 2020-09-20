using System;
using System.Linq;


namespace AGC022
{
    class A
    {
        static void Main(string[] args)
        {
            //input
            string S = Console.ReadLine();

            //文字用の配列と、Sで使われている文字のカウント
            int[] C = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                C[S[i] - 'a']++;
            }

            int sum = C.Sum();

            //|S| < 26のとき
            ////使われていない文字で、一番最小のものを最後につける
            if (sum < 26)
            {
                for (int i = 0; i < C.Length; i++)
                {
                    if (C[i] == 0)
                    {
                        Console.WriteLine(S + (char)(i + (int)'a'));
                        return;
                    }
                }
            }
            else
            {
                int num = 0;
                for (int i = S.Length - 1; 0 < i; i--)
                {
                    if (S[i] > S[i - 1]) { num = i; break; }
                    if (i == 1) { Console.WriteLine(-1); return; }
                }

                int c = int.MaxValue;
                string s1 = "";
                for (int i = S.Length - 1; num <= i; i--)
                {
                    int temp = (int)S[num - 1] - (int)S[i];
                    int temp2 = Math.Abs(temp);
                    if (temp < 0 && temp2 < c)
                    {
                        c = temp;
                        s1 = S[i].ToString();
                    }
                }

                string sub = S.Substring(0, num - 1) + s1;
                Console.WriteLine(sub);
            }
        }
    }
}
