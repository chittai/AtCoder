using System;
using System.Linq;

namespace ARC067
{
    class D
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long A = input[1];
            long B = input[2];

            long[] X = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long[] Res = new long[N];
            long distance = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (B <= A) { Res[i] = B; }
                else
                {
                    distance = X[i + 1] - X[i];
                    Res[i] = Math.Min(A * distance, B);
                }
            }
            Console.WriteLine(Res.Sum());
        }
    }
}
