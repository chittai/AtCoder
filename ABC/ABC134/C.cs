using System;
using System.Linq;

namespace ABC134
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            int[] Atmp = new int[N];
            Atmp = A.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < N; i++)
            {
                if (A[i] != Atmp[0])
                {
                    Console.WriteLine(Atmp[0]);
                }
                else if (A[i] == Atmp[0])
                {
                    Console.WriteLine(Atmp[1]);
                }
            }
        }
    }
}
