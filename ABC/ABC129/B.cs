using System;

namespace ABC129
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] W = new int[N];
            for (int i = 0; i < N; i++)
            {
                W[i] = int.Parse(input[i]);
            }

            int[] S = new int[N + 1];
            S[0] = 0;
            for (int i = 0; i < N; i++)
            {
                S[i + 1] += S[i] + W[i];
            }

            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = Math.Abs(S[N] - 2 * S[i]);
            }

            Array.Sort(A);

            Console.WriteLine(A[0]);

        }
    }
}
