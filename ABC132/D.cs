using System;
using System.Linq;

namespace ABC132
{
    class D
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long K = input[1];

            init(4005);

            long red = 0;
            long blue = 0;
            for (long i = 1; i <= K; i++)
            {
                if (N - K + 1 < i) red = 0;
                else red = CalcCombination(N - K + 1, i);

                blue = CalcCombination(K - 1, i - 1);

                Console.WriteLine((blue * red) % 1000000007);

            }

        }

        // Combination
        static long[,] c;
        public static long[,] init(long x)
        {
            c = new long[x + 5, x + 5];
            c[0, 0] = 1;
            for (long i = 1; i <= x; i++)
            {
                for (long j = 0; j <= i; j++)
                {
                    if (j == 0) c[i, j] = c[i - 1, j];
                    else c[i, j] = (c[i - 1, j] + c[i - 1, j - 1]) % 1000000007;
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
