using System;
using System.Linq;
using System.Collections.Generic;

/* Dictionaryの練習 */

namespace ABC061
{
    class B
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = input[0];
            int M = input[1];

            int[] A = new int[N];
            int a = 0;
            int b = 0;
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                a = input[0] - 1;
                b = input[1] - 1;

                A[a]++;
                A[b]++;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
