/* 数学的処理をまとめる */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Etc
{

    class PF
    {
        //prime factorization(素因数分解)
        public static void CalcPF()
        {
            int N = int.Parse(Console.ReadLine());

            int temp;
            int j;
            int[] Res = new int[N + 1];

            for (int i = N; i > 1; i--)
            {
                j = 2;
                temp = i;
                while (j <= N)
                {
                    while (temp % j == 0)
                    {
                        Res[j]++;
                        temp /= j;
                    }
                    j++;
                }
            }
        }
    }

    class GCD
    {
        public static long CalcGCD(long a, long b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }
    }
    class Combination
    {
        // Combination
        static int[,] c;
        public static int[,] init(int x)
        {
            c = new int[x + 5, x + 5];
            c[0, 0] = 1;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0) c[i, j] = c[i - 1, j];
                    else c[i, j] = c[i - 1, j] + c[i - 1, j - 1];
                }
            }
            return c;
        }

        public static int CalcCombination(int n, int k)
        {
            return c[n, k];
        }

    }
}