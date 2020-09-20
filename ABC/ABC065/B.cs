using System;
using System.Linq;

namespace ABC065
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N + 1];

            for (int i = 1; i <= N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int count = 1;
            int a = 1;
            for (int i = 0; i < N; i++)
            {
                if (A[a] == 2) { Console.WriteLine(count); return; }
                a = A[a];
                count++;

            }
            Console.WriteLine(-1);
        }
    }
}
