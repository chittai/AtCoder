using System;
using System.Linq;

namespace ABC172
{
    class C
    {
        static void Main(string[] args)
        {
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            var NMK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var B = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var N = NMK[0]; var M = NMK[1]; var K = NMK[2];

            var Acs = new long[N + 1];
            for (int i = 0; i < N; i++)
            {
                Acs[i + 1] = A[i] + Acs[i];
            }
            var Bcs = new long[M + 1];
            for (int i = 0; i < M; i++)
            {
                Bcs[i + 1] = B[i] + Bcs[i];
            }

            var max = 0;
            var tmpmax = 0;
            for (int i = 0; i < N + 1; i++)
            {
                if (K < Acs[i]) continue;
                tmpmax = i;
                var tmp = K - Acs[i];
                if (0 <= Array.BinarySearch(Bcs, tmp))
                {
                    tmpmax += Array.BinarySearch(Bcs, tmp);
                }
                else
                {
                    tmpmax += ~Array.BinarySearch(Bcs, tmp) - 1;
                }
                max = Math.Max(max, tmpmax);
            }
            Console.WriteLine(max);
        }
    }
}
