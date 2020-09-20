using System;
using System.Linq;

namespace ABC079
{
    class D2
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Y = input[0];
            int X = input[1];

            int C = 10;
            long[,] dist = new long[C, C];
            for (int y = 0; y < C; y++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int x = 0; x < C; x++)
                {
                    dist[x, y] = input[x];
                }
            }

            for (int k = 0; k < C; k++)
            {

                for (int i = 0; i < C; i++)
                {
                    for (int j = 0; j < C; j++)
                    {
                        dist[i, j] = Math.Min(dist[i, j], dist[i, k] + dist[k, j]);
                    }
                }
            }


            int[] count = new int[C];
            for (int y = 0; y < Y; y++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int x = 0; x < X; x++)
                {
                    if (-1 < input[x]) count[input[x]]++;
                }
            }

            long res = 0;
            for (int i = 0; i < C; i++)
            {
                res += count[i] * dist[1, i];
            }
            Console.WriteLine(res);

        }
    }
}
