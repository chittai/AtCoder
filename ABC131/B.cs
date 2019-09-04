
using System;

namespace ABC131
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int L = int.Parse(input[1]);

            int[] aji = new int[N];

            for (int i = 0; i < N; i++)
            {
                aji[i] = L + i;
            }

            if (0 <= L) { aji[0] = 0; }
            if (L < 0)
            {
                if (Math.Abs(L) >= Math.Abs(N))
                {
                    aji[N - 1] = 0;
                }
            }

            int res = 0;
            foreach (var k in aji)
            {
                res += k;
            }
            Console.WriteLine(res);
        }
    }
}
