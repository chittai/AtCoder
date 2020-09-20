using System;
using System.Linq;

namespace AGC041
{
    class A
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long A = input[1];
            long B = input[2];

            if ((B - A) % 2 == 0) { Console.WriteLine((B - A) / 2); return; }

            long l = B - 1;
            long r = N - A;

            long res = 0;
            if (l < r)
            {
                res = A + (B - A) / 2;
            }
            else if (r < l)
            {
                res = (N - B + 1) + (N - (A + (N - B + 1))) / 2;
            }
            else
            {
                res = A + (B - A) / 2;
            }

            Console.WriteLine(res);

        }
    }
}
