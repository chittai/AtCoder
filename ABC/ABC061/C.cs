using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC061
{
    class C
    {
        static void Main(string[] args)
        {

            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long N = input[0];
            long K = input[1];

            long[] Count = new long[100000 + 10];
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long a = input[0];
                long b = input[1];

                Count[a] += b;
            }

            long bCount = 0;
            for (int i = 0; i < Count.Length; i++)
            {
                bCount += Count[i];
                if (K <= bCount) { Console.WriteLine(i); return; }
            }
        }
    }
}
