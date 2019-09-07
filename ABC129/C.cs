using System;
using System.Linq;

namespace ABC129
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long N = long.Parse(input[0]);
            long M = long.Parse(input[1]);

            long[] a = new long[M];
            for (int i = 0; i < M; i++)
            {
                a[i] = long.Parse(Console.ReadLine());
            }
            Console.WriteLine(CalcStep(N - 1, a) + CalcStep(N - 1, a));
        }

        static long CalcStep(long N, long[] M)
        {

            long ans1 = 0;
            long ans2 = 0;

            // 今の段
            if (N == 0) { return 1; }
            // 次の段の評価
            if (0 <= N && !M.Contains(N))
            {
                ans1 += (CalcStep(N - 1, M)) % 1000000007;
            }
            if (0 <= N && !M.Contains(N))
            {
                ans2 += CalcStep(N - 2, M) % 1000000007;
            }

            return ans1 + ans2;
        }
    }
}
