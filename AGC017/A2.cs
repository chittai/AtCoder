using System;
using System.Linq;

namespace AGC017
{
    class A2
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long P = input[1];
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long eCount = 0;
            long oCount = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0) eCount++;
                else oCount++;
            }

            if (N == eCount && P == 1) Console.WriteLine(0);
            else if (N == eCount && P == 0) Console.WriteLine(Math.Pow(2, N));
            else Console.WriteLine(Math.Pow(2, N - 1));
        }
    }
}
