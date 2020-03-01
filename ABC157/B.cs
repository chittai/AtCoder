using System;
using System.Linq;

namespace ABC157
{
    class B
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    A[i, j] = input[j];
                }
            }

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int b = int.Parse(Console.ReadLine());

                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (A[j, k] == b) A[j, k] = 0;
                    }
                }
            }

            // yoko
            if (A[0, 0] == 0 && A[0, 1] == 0 && A[0, 2] == 0) { Console.WriteLine("Yes"); return; }
            if (A[1, 0] == 0 && A[1, 1] == 0 && A[1, 2] == 0) { Console.WriteLine("Yes"); return; }
            if (A[2, 0] == 0 && A[2, 1] == 0 && A[2, 2] == 0) { Console.WriteLine("Yes"); return; }

            // tate
            if (A[0, 0] == 0 && A[1, 0] == 0 && A[2, 0] == 0) { Console.WriteLine("Yes"); return; }
            if (A[0, 1] == 0 && A[1, 1] == 0 && A[2, 1] == 0) { Console.WriteLine("Yes"); return; }
            if (A[0, 2] == 0 && A[1, 2] == 0 && A[2, 2] == 0) { Console.WriteLine("Yes"); return; }

            // naname
            if (A[0, 0] == 0 && A[1, 1] == 0 && A[2, 2] == 0) { Console.WriteLine("Yes"); return; }
            if (A[0, 2] == 0 && A[1, 1] == 0 && A[2, 0] == 0) { Console.WriteLine("Yes"); return; }

            Console.WriteLine("No");

        }
    }
}
