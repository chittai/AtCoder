using System;
using System.Collections.Generic;
using System.Linq;

namespace AGC039
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            int[,] S = new int[N, N];
            string s;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    s = Console.ReadLine();
                    S[i, j] = int.Parse(s[j].ToString());
                }
            }

            List<int> Dup = new List<int>();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (S[i, j] == 1) Dup.Add(j);
                }

                foreach (var item in Dup)
                {
                    if (S[i, item] == 1) { Console.WriteLine("No"); return; }
                }
            }
        }
    }
}
