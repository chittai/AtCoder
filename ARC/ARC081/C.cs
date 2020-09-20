using System;
using System.Linq;

namespace ARC081
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();

            long res = 1;
            int count = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (i < N && A[i] == A[i + 1]) { res *= A[i]; count++; i++; }
                if (count == 2) break;
            }

            if (count < 2) Console.WriteLine(0);
            else Console.WriteLine(res);
        }
    }
}
