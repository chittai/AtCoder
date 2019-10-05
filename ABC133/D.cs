using System;
using System.Linq;

namespace ABC133
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += A[i];
            }

            long[] X = new long[N];

            long sumA = 0;
            for (int i = 1; i < N - 1; i += 2)
            {
                sumA += A[i];
            }

            X[0] = sum - 2 * sumA;

            for (int i = 1; i < N; i++)
            {
                X[i] = 2 * A[i - 1] - X[i - 1];
            }

            Console.WriteLine(string.Join(" ", X));
        }
    }
}
