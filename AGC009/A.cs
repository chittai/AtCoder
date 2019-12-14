using System;
using System.Linq;

namespace AGC009
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                A[i] = input[0];
                B[i] = input[1];
            }

            long plus = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                long x = (A[i] + plus) % B[i];
                if (x != 0) { plus += B[i] - x; }
            }
            Console.WriteLine(plus);
        }
    }
}
