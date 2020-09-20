using System;
using System.Linq;

namespace ABC048
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long x = input[1];

            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long count = 0;
            long xSum = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (x < a[i + 1] + a[i])
                {
                    xSum = (a[i + 1] + a[i]) - x;
                    count += xSum;

                    if (xSum <= a[i + 1])
                    {
                        a[i + 1] -= xSum;
                    }
                    else
                    {
                        xSum -= a[i + 1];
                        a[i + 1] = 0;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
