using System;

namespace ABC131
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long c = long.Parse(input[2]);
            long d = long.Parse(input[3]);

            long lcm = (c * d) / CalGcd(c, d);

            long res = (b - a + 1) - (b / c - (a - 1) / c) - (b / d - (a - 1) / d) + (b / lcm - (a - 1) / lcm);

            Console.WriteLine(res);

        }

        static long CalGcd(long a, long b)
        {
            if (b == 0) { return a; }
            return CalGcd(b, a % b);
        }
    }
}
