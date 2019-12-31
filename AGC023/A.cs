using System;
using System.Linq;

namespace AGC023
{
    class A
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long[] S = new long[N + 1];
            for (int i = 0; i < N; i++)
            {
                S[i + 1] = S[i] + A[i];
            }

            S = S.OrderBy(x => x).ToArray();
            long res = 0;
            for (int i = 0; i < N; i++)
            {
                long count = 1;
                while (i < N && S[i] == S[i + 1])
                {
                    count++;
                    i++;
                }

                if (1 < count) res += count * (count - 1) / 2;

            }
            Console.WriteLine(res);
        }
    }
}
