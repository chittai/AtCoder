using System;

namespace ABC140
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] B = new int[N - 1];
            for (int i = 0; i < N - 1; i++)
            {
                B[i] = int.Parse(input[i]);
            }

            int[] A = new int[N];
            A[0] = B[0];
            A[N - 1] = B[N - 2];
            for (int i = 1; i < N - 1; i++)
            {
                A[i] = Math.Min(B[i - 1], B[i]);
            }

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                count += A[i];
            }
            Console.WriteLine(count);
        }
    }
}
