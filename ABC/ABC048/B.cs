using System;

namespace ABC048
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long x = long.Parse(input[2]);

            long start = 0;
            if (a % x == 0) start = (a / x) - 1;
            else start = a / x;

            long end = b / x;
            Console.WriteLine(end - start);
        }
    }
}
