using System;
using System.Linq;

namespace ABC065
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];
            long mod = 1000000007;


            if (M < N - 1 || N < M - 1)
            { Console.WriteLine(0); return; }
            else
            {
                long p = 1;
                long p2 = 1;
                long res = 0;
                for (int i = Math.Max(N, M); i >= 1; i--)
                {
                    p = (p * i) % mod;
                    if (i < Math.Max(N, M)) p2 = (p2 * i) % mod;
                }

                if (M == N)
                {
                    res = 2 * (p * p) % mod;
                }
                else
                {
                    res = (p * p2) % mod;
                }
                Console.WriteLine(res);
            }
        }
    }
}
