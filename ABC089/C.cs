using System;

namespace ABC089
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long m = 0;
            long a = 0;
            long r = 0;
            long c = 0;
            long h = 0;
            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                char s = S[0];
                if (s == 'M') m++;
                if (s == 'A') a++;
                if (s == 'R') r++;
                if (s == 'C') c++;
                if (s == 'H') h++;
            }


            int[] P = { 0, 0, 0, 0, 0, 0, 1, 1, 1, 2 };
            int[] Q = { 1, 1, 1, 2, 2, 3, 2, 2, 3, 3 };
            int[] R = { 2, 3, 4, 3, 4, 4, 3, 4, 4, 4 };

            long[] D = new long[] { m, a, r, c, h };
            long res = 0;
            for (int i = 0; i < 10; i++)
            {
                res += D[P[i]] * D[Q[i]] * D[R[i]];
            }

            Console.WriteLine(res);
        }
    }
}
