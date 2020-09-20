using System;
using System.Linq;

namespace ARC093
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] A2 = new int[A.Length + 2];
            for (int i = 0; i < A.Length; i++)
            {
                A2[i + 1] = A[i];
            }

            int sum = 0;
            for (int i = 0; i < N + 1; i++)
            {
                sum += Math.Abs(A2[i + 1] - A2[i]);
            }

            for (int i = 1; i < N + 1; i++)
            {
                Console.WriteLine(sum + Math.Abs(A2[i - 1] - A2[i + 1]) - (Math.Abs(A2[i - 1] - A2[i]) + Math.Abs(A2[i] - A2[i + 1])));
            }
        }
    }
}

