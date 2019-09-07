using System;

namespace ABC140
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(input[i]);
            }

            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(input[i]);
            }

            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N - 1; i++)
            {
                C[i] = int.Parse(input[i]);
            }

            int count = B[A[0] - 1];
            for (int i = 1; i < N; i++)
            {
                if (A[i] == A[i - 1] + 1)
                {
                    count += B[A[i] - 1] + C[A[i] - 2];
                }
                else
                {
                    count += B[A[i] - 1];
                }
            }

            Console.WriteLine(count);

        }
    }
}
