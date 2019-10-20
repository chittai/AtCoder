using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC143
{
    class D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var L = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();

            var indexMax = 0;
            var count = 0;

            for (int i = 0; i < N - 2; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    //indexMax = Array.BinarySearch(L, L[i] + L[j]);
                    //if (indexMax < 0) indexMax = ~indexMax;
                    //count += indexMax - (j + 1);

                    for (int k = N - 1; j < k; k--)
                    {
                        if (L[k] < L[i] + L[j])
                        {
                            count += k - j;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
