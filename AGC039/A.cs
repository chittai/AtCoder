using System;

namespace AGC039
{
    class A
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            long K = long.Parse(Console.ReadLine());

            long count = 1;
            long res = 0;

            bool eQu = false;
            bool sC = false;
            bool eC = false;

            for (int i = 0; i < S.Length - 1;)
            {
                if (S[i] != S[i + 1])
                {
                    i++;
                }
                else
                {
                    while (i < S.Length - 1 && S[i] == S[i + 1])
                    {
                        count++;
                        i++;
                    }
                    i++;
                }
                res += count / 2;
                if (count == S.Length) eQu = true;
                count = 1;
            }

            res *= K;

            int count2 = 1;
            int count3 = 1;
            if (1 < K && S[0] == S[S.Length - 1] && !eQu)
            {
                for (int i = 0; i < S.Length - 1; i++)
                {
                    if (S[i] == S[i + 1]) count2++;
                    else break;
                }
                if (count2 % 2 == 1) { sC = true; }

                for (int i = S.Length - 1; 0 < i; i--)
                {
                    if (S[i] == S[i - 1]) count3++;
                    else break;
                }
                if (count3 % 2 == 1) { eC = true; }
            }

            //if (S.Length != 1 && 2 <= K && S[0] != S[1] && S[S.Length - 2] != S[S.Length - 1] && S[0] == S[S.Length - 1]) { res += K - 1; }
            if (S.Length != 1 && 2 <= K && sC && eC && S[0] == S[S.Length - 1]) { res += K - 1; }
            if (S.Length == 1) res = K / 2;
            if (eQu && S.Length % 2 == 1) res += K / 2;



            Console.WriteLine(res);
        }
    }
}
