using System;
using System.Linq;

namespace AGC017
{
    class A
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long P = input[1];
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long eCount = 0;
            long oCount = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0) eCount++;
                else oCount++;
            }
            if (P == 1 && oCount == 0) { Console.WriteLine(0); return; }

            double res = 0;
            //res += Math.Pow(2, eCount); // 何も選ばないも含んでいる
            long[,] c = new long[oCount + 5, oCount + 5];
            c[0, 0] = 1;
            for (int i = 1; i <= oCount; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0) c[i, j] = c[i - 1, j];
                    else c[i, j] = c[i - 1, j] + c[i - 1, j - 1];
                }
            }

            for (int i = 0; i <= oCount; i++)
            {
                if (i % 2 == P) res += Math.Pow(2, eCount) * c[oCount, i];
            }
            Console.WriteLine(res);
        }
    }
}
