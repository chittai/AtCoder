using System;
using System.Linq;

namespace ABC132
{
    class D
    {
        static long[,] c;
        static long mod = 1000000007;
        static void Main(string[] args)
        {
            //input
            var nk = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var n = nk[0]; var k = nk[1];
            init(n);
            //for i: 0 - k
            //n-k_C_i * n-1_C_i
            for (long i = 1; i <= k; i++)
            {
                if (n - k + 1 < i) Console.WriteLine(0);
                else Console.WriteLine((CalcCombination(n - k + 1, i) * CalcCombination(k - 1, i - 1)) % mod);
            }
        }

        public static long[,] init(long x)
        {
            c = new long[x + 5, x + 5];
            c[0, 0] = 1;
            for (long i = 1; i <= x; i++)
            {
                for (long j = 0; j <= i; j++)
                {
                    if (j == 0) c[i, j] = c[i - 1, j];
                    else c[i, j] = (c[i - 1, j] + c[i - 1, j - 1]) % mod;
                }
            }
            return c;
        }

        public static long CalcCombination(long n, long k)
        {
            return c[n, k];
        }

    }
}
