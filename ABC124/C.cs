using System;

namespace ABC124
{
    class C
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int wCount = 0;
            int bCount = 0;

            // 先頭が白のパターン
            for (int i = 0; i < S.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    if (S[i] != '1') { wCount++; }
                }
                if ((i % 2) == 1)
                {
                    if (S[i] != '0') { wCount++; }
                }
            }

            for (int i = 0; i < S.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    if (S[i] != '0') { bCount++; }
                }
                if ((i % 2) == 1)
                {
                    if (S[i] != '1') { bCount++; }
                }
            }
            Console.WriteLine(Math.Min(wCount, bCount));
        }
    }
}