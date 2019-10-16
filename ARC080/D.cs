using System;
using System.Linq;

namespace ARC080
{
    class D
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];

            int N = int.Parse(Console.ReadLine());

            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = H * W;
            int[,] HW = new int[H, W];

            int index = 1;
            int j = 0;
            for (int i = 0; i < H; i++)
            {
                if (i % 2 == 0)
                {
                    j = 0;
                    while (j < W)
                    {
                        //Console.WriteLine(a[index]);
                        HW[i, j] = index;
                        a[index - 1]--;
                        if (a[index - 1] == 0) index++;
                        j++;
                    }
                }
                else
                {
                    j = W - 1;
                    while (0 <= j)
                    {
                        HW[i, j] = index;
                        a[index - 1]--;
                        if (a[index - 1] == 0) index++;
                        j--;
                    }
                }
            }

            for (int i = 0; i < H; i++)
            {
                for (int k = 0; k < W; k++)
                {
                    Console.Write(HW[i, k]);
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}
