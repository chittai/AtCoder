using System;
using System.Linq;

namespace ABC083
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long X = input[0];
            long Y = input[1];

            long res = X;
            int i = 0;
            //while (X * Math.Pow(2, i) <= Y) i++;

            while (res <= Y)
            {
                i++;
                res *= 2;
            }

            Console.WriteLine(i);
        }
    }
}
