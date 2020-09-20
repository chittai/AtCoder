using System;

namespace AGC037
{
    class A
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string temp = S[0].ToString();
            int res = 1;
            for (int i = 1; i < S.Length; i++)
            {
                if (temp.Length == 2)
                {
                    res++;
                    temp = S[i].ToString();
                }
                else
                {
                    if (temp != S[i].ToString())
                    {
                        res++;
                        temp = S[i].ToString();
                    }
                    else
                    {
                        if (i < S.Length - 1) { res++; temp = S.Substring(i, 2); }
                        else break;
                        i++;
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
