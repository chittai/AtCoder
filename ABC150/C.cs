using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC150
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] P = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] Q = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int[] A = new int[(int)Math.Pow(N, N)];
            long resP = 0;
            long resQ = 0;

            int[] existP = new int[N + 10];
            int[] existQ = new int[N + 10];
            for (int i = 0; i < N - 1; i++)
            {
                long count = 0;
                existP[P[i]] = 1;
                for (int j = 0; j < N; j++)
                {
                    if (j < P[i] && 0 < existP[j]) count++;
                }
                if (count == 0) resP += Factorial((N - 1) - i) * (P[i] - 1);
                else resP += Factorial((N - 1) - i) * (P[i] - 1 - count);

                count = 0;
                existQ[Q[i]] = 1;
                for (int j = 0; j < N; j++)
                {
                    if (j < Q[i] && 0 < existQ[j]) count++;
                }
                if (count == 0) resQ += Factorial((N - 1) - i) * (Q[i] - 1);
                else resQ += Factorial((N - 1) - i) * (Q[i] - 1 - count);
            }
            Console.WriteLine(Math.Abs(resP - resQ));
        }

        public static long Factorial(int n)
        {
            if (n == 0)
                return 1L;
            return n * Factorial(n - 1);
        }

    }
}
