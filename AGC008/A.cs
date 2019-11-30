using System;
using System.Linq;

namespace AGC008
{
    class A
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long x = input[0];
            long y = input[1];

            if ((0 <= x && 0 <= y) || (x <= 0 && y <= 0))
            {
                if (x <= y)
                {
                    Console.WriteLine(Math.Abs(x - y));
                }
                else
                {
                    if (x != 0 && y != 0) { Console.WriteLine(Math.Abs(x - y) + 2); }
                    else { Console.WriteLine(Math.Abs(x - y) + 1); }
                }
            }
            else
            {
                Console.WriteLine(Math.Abs(Math.Abs(x) - Math.Abs(y)) + 1);
            }
        }
    }
}
