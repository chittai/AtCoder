using System;

namespace PAST001
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = new long[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = long.Parse(Console.ReadLine());
            }

            for (int i = 1; i < N; i++)
            {
                if (A[i - 1] == A[i]) Console.WriteLine("stay");
                else if (A[i - 1] > A[i]) Console.WriteLine("down {0}", A[i - 1] - A[i]);
                else if (A[i - 1] < A[i]) Console.WriteLine("up {0}", A[i] - A[i - 1]);

            }
        }
    }
}
