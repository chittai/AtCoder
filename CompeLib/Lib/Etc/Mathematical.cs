/* 数学的処理をまとめる */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Etc
{

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