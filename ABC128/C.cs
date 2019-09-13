using System;

namespace ABC128
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] k = new int[M];
            int[,] s = new int[M, 20];

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split(' ');
                k[i] = int.Parse(input[0]);

                for (int j = 1; j <= k[i]; j++)
                {
                    s[i, j] = int.Parse(input[j]);
                }
            }

            input = Console.ReadLine().Split(' ');
            int[] p = new int[M];
            for (int i = 0; i < M; i++)
            {
                p[i] = int.Parse(input[i]);
            }

            int[] a = new int[N];
            CalcSw(N, a, M, k, s, p);

            Console.WriteLine(count);

        }

        static int count = 0;
        static void CalcSw(int N, int[] a, int M, int[] k, int[,] s, int[] p)
        {
            if (N == 0)
            {
                int c = 0;
                for (int i = 0; i < M; i++)
                {
                    c = 0;
                    for (int j = 1; j <= k[i]; j++)
                    {
                        if (a[s[i, j] - 1] == 1) { c++; }
                    }
                    if ((c % 2) != p[i]) { return; }
                }
                count++;
                return;
            }

            N--;
            a[N] = 0;
            CalcSw(N, a, M, k, s, p);
            a[N] = 1;
            CalcSw(N, a, M, k, s, p);
        }
    }
}
