using System;
using System.Linq;

namespace ARC102
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];

            long[] num = new long[K];
            for (int i = 1; i <= N; i++) num[i % K]++;

            long res = 0;
            for (int a = 0; a < K; a++)
            {
                int b = (K - a) % K;
                int c = (K - a) % K;

                if ((b + c) % K != 0) continue;
                res += num[a] * num[b] * num[c];

            }
            Console.WriteLine(res);
        }
    }
}
