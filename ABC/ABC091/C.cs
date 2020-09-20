using System;
using System.Linq;
using System.Collections;

namespace ABC091
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());

            int[][] ab = new int[N][];
            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ab[i] = new int[] { input[0], input[1] };
            }

            int[][] cd = new int[N][];
            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                cd[i] = new int[] { input[0], input[1] };
            }

            Array.Sort(cd, StructuralComparisons.StructuralComparer);

            bool[] Seleced = new bool[N];
            int res = 0;
            for (int i = 0; i < N; i++)
            {
                int index = -1;
                int max = int.MinValue;
                for (int j = 0; j < N; j++)
                {
                    if (ab[j][0] < cd[i][0] && ab[j][1] < cd[i][1] && !Seleced[j])
                    {
                        if (max < ab[j][1])
                        {
                            max = ab[j][1];
                            index = j;
                        }
                    }
                }
                if (-1 < index) { Seleced[index] = true; res++; }
            }

            //output
            Console.WriteLine(res);
        }
    }
}
