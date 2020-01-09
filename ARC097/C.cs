using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC097
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            string s = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());

            //a-z
            int[] alpha = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                alpha[s[i] - 'a']++;
            }

            string res = "";
            if (K <= alpha.Count(x => 0 < x))
            {
                int count = 0;
                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (0 < alpha[c - 'a'])
                    {
                        count++;
                        if (count == K) res = c.ToString();
                    }
                }
            }
            else
            {
                int rank = K - alpha.Count(x => 0 < x);
                List<string> list = new List<string>();
                for (int i = 2; i <= 5; i++)
                {
                    for (int j = 0; j < s.Length - i + 1; j++)
                    {
                        string tmp = s.Substring(j, i);
                        list.Add(tmp);
                    }

                    list = list.OrderBy(x => x).ToList();
                    if (rank <= list.Count) { res = list[rank - 1]; break; }
                }
            }
            Console.WriteLine(res);
        }
    }
}
