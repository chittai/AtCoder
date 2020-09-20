using System;
using System.Linq;

namespace ARC100
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                B[i] = A[i] - (i + 1);
            }
            B = B.OrderBy(x => x).ToArray();

            int res = 0;
            if (B.Count() == 1) res = B[0];
            else if (B.Count() % 2 == 1) res = B[B.Count() / 2];
            else res = (B[B.Count() / 2] + B[B.Count() / 2 - 1]) / 2;

            long ans = 0;
            for (int i = 0; i < N; i++)
            {
                ans += Math.Abs(A[i] - (i + 1 + res));
            }

            Console.WriteLine(ans);
        }
    }
}
