using System;
using System.Linq;

namespace ARC066
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int[] AA = new int[100010];
            for (int i = 0; i < N; i++)
            {
                AA[A[i]]++;
            }

            if (N % 2 != 0 && AA[0] != 1) { Console.WriteLine(0); return; }

            long current = 0;
            if (N % 2 != 0) { current = 2; }
            else { current = 1; }

            long res = 1;
            while (current < N)
            {
                if (AA[current] == 2) { current += 2; res = (res * 2) % 1000000007; }
                else { Console.WriteLine(0); return; }
            }
            Console.WriteLine(res);
        }
    }
}
