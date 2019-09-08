using System;
using System.Linq;

namespace ABC081
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(input[i]);
            }

            int count = 0;
            while (true)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[j] % 2 != 0) { Console.WriteLine(count); return; }
                    A[j] = A[j] / 2;
                }
                count++;
            }
        }
    }
}
