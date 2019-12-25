using System;
using System.Linq;

namespace ABC079
{
    class D
    {
        static long[] res;
        static int[,] c;

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Y = input[0];
            int X = input[1];

            int C = 10;
            c = new int[C, C];
            for (int y = 0; y < C; y++)
            {
                int[] cij = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int x = 0; x < C; x++)
                {
                    c[x, y] = cij[x];
                }
            }

            int[,] a = new int[X, Y];
            int[] count = new int[10];
            for (int y = 0; y < Y; y++)
            {
                int[] aij = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int x = 0; x < X; x++)
                {
                    a[x, y] = aij[x];
                    if (-1 < aij[x]) count[aij[x]]++;
                }
            }

            res = new long[10];
            for (int y = 0; y < 10; y++)
            {
                res[y] = c[1, y];
            }

            for (int i = 0; i < 10; i++)
            {
                Change(i, i, 0);
            }

            //Console.WriteLine(string.Join(",", res));
            long ans = 0;
            for (int i = 0; i < 10; i++)
            {
                ans += res[i] * count[i];
            }
            Console.WriteLine(ans);

            /*
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    Console.Write(a[x, y]);
                }
                Console.WriteLine();
            }
            */


        }
        static void Change(int start, int now, int cost)
        {
            //if (start == 8) Console.WriteLine(cost);
            for (int next = 0; next < 10; next++)
            {
                if (next == now) continue;
                cost += c[next, now];

                if (next == 1) { res[start] = Math.Min(res[start], cost); }
                if (cost < res[start]) Change(start, next, cost);

                cost -= c[next, now];
            }
        }
    }
}
