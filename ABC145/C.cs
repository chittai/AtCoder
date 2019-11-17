using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC145
{
    class C
    {
        static double total = 0;
        static long[] x;
        static long[] y;

        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());
            x = new long[N];
            y = new long[N];

            for (long i = 0; i < N; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                x[i] = input[0];
                y[i] = input[1];
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != j) total += Math.Sqrt(Math.Pow(x[j] - x[i], 2) + Math.Pow(y[j] - y[i], 2));
                }
            }

            Console.WriteLine(total / N);

        }
    }
}

