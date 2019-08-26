using System;
using System.Linq;

namespace ABC109
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input;
            input = Console.ReadLine().Split(' ');
            long N = long.Parse(input[0]);
            long X = long.Parse(input[1]);

            long[] dist = new long[N];
            input = Console.ReadLine().Split(' ');
            for (long i = 0; i < N; i++)
            {
                dist[i] = Math.Abs(X - long.Parse(input[i]));
            }

            dist = dist.OrderByDescending(x => x).ToArray();

            long gcd = dist[0];
            //long result = 0;
            for (long i = 0; i < N; i++)
            {
                gcd = CalGcd(gcd, dist[i]);
            }
            Console.WriteLine(gcd);
        }

        static long CalGcd(long x, long y)
        {
            if (y == 0) { return x; }
            return CalGcd(y, x % y);
        }
    }
}
