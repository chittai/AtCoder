using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC162
{
    class D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            long sum = 0;

            var Sr = new int[N + 1];
            var Sg = new int[N + 1];
            var Sb = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'R') Sr[i + 1] = Sr[i] + 1;
                else Sr[i + 1] = Sr[i];

                if (S[i] == 'G') Sg[i + 1] = Sg[i] + 1;
                else Sg[i + 1] = Sg[i];

                if (S[i] == 'B') Sb[i + 1] = Sb[i] + 1;
                else Sb[i + 1] = Sb[i];
            }

            //Console.WriteLine(string.Join(",", Sr));
            //Console.WriteLine(string.Join(",", Sg));
            //Console.WriteLine(string.Join(",", Sb));

            for (int i = 0; i < N - 2; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    if (S[i] == S[j]) continue;
                    if ((S[i] == 'R' && S[j] == 'G') || (S[i] == 'G' && S[j] == 'R'))
                    {
                        //Console.WriteLine("B");
                        sum += Sb[N] - Sb[j + 1];
                        if (j + (j - i) < N && S[j + (j - i)] == 'B') sum--;
                    } // k = B
                    if ((S[i] == 'R' && S[j] == 'B') || (S[i] == 'B' && S[j] == 'R'))
                    {
                        //Console.WriteLine("G");
                        sum += Sg[N] - Sg[j + 1];
                        if (j + (j - i) < N && S[j + (j - i)] == 'G') sum--;
                    } // k = G
                    if ((S[i] == 'G' && S[j] == 'B') || (S[i] == 'B' && S[j] == 'G'))
                    {
                        //Console.WriteLine("R");
                        sum += Sr[N] - Sr[j + 1];
                        if (j + (j - i) < N && S[j + (j - i)] == 'R') sum--;
                    } // k = R
                }
            }
            Console.WriteLine(sum);
        }
    }
}

