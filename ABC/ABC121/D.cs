using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC121
{
    class D
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long A = input[0]; long B = input[1];

            Console.WriteLine(F(B) ^ F(A - 1));
        }

        static long F(long x)
        {
            switch (x % 4)
            {
                case 0: return x;
                case 1: return 1;
                case 2: return x + 1;
                case 3: return 0;
                default: return 0;
            }
        }

    }
}
