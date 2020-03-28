using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC160
{
    class D
    {
        static void Main(string[] args)
        {
            var nxy = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var n = nxy[0]; var x = nxy[1] - 1; var y = nxy[2] - 1;
            var dist1 = new long[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i != j)
                    {
                        dist1[i, j] = Math.Min(Math.Abs(j - i), Math.Abs(x - i) + 1 + Math.Abs(j - y));
                    }
                }
            }

            /*
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(dist1[i, j]);
                }
                Console.WriteLine();
            }
            */

            var res = new long[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[dist1[i, j]]++;
                }
            }

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
