using System;
using System.Linq;
using System.Collections;

namespace ABC103
{
    class D
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            int[][] ab = new int[M][];

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ab[i] = new int[] { input[1], input[0] };
            }
            Array.Sort(ab, StructuralComparisons.StructuralComparer);

            int R = ab[0][0];
            int res = 1;
            for (int i = 1; i < M; i++)
            {
                if (R <= ab[i][1])
                {
                    R = ab[i][0];
                    res++;

                }
            }
            Console.WriteLine(res);
        }
    }
}
