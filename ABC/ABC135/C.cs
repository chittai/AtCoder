using System;
using System.Linq;

namespace ABC135
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');
            int[] A = new int[N + 1];
            for (int i = 0; i < N + 1; i++)
            {
                A[i] = int.Parse(input[i]);
            }

            input = Console.ReadLine().Split(' ');
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(input[i]);
            }

            long beforeSum = 0;
            long afterSum = 0;

            for (int i = 0; i < N; i++)
            {
                beforeSum += B[i];
            }

            int tmp = 0;
            for (int i = 0; i < N; i++)
            {
                tmp = B[i] - A[i];
                if (tmp < 0) { B[i] = 0; A[i] = Math.Abs(tmp); }
                if (tmp == 0) { B[i] = 0; A[i] = 0; }
                if (tmp > 0) { B[i] = Math.Abs(tmp); A[i] = 0; }

                tmp = B[i] - A[i + 1];
                if (tmp < 0) { B[i] = 0; A[i + 1] = Math.Abs(tmp); }
                if (tmp == 0) { B[i] = 0; A[i + 1] = 0; }
                if (tmp > 0) { B[i] = Math.Abs(tmp); A[i + 1] = 0; }
            }

            for (int i = 0; i < N; i++)
            {
                afterSum += B[i];
            }
            Console.WriteLine(beforeSum - afterSum);
        }
    }
}
