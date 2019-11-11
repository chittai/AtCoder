using System;
using System.Linq;

namespace NSPGY001
{
    class B
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long K = input[1];
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long mod = 1000000000 + 7;

            long res = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i] > A[j]) res++;
                }
            }

            long res2 = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i] > A[j]) res2++;
                }
            }

            long ans = 0;
            long c = K * (K - 1) / 2 % mod;
            ans = (res * K % mod + res2 * c % mod) % mod;
            Console.WriteLine(ans);
        }
    }
}
