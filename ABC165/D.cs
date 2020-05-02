using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC165
{
    class D
    {
        static void Main(string[] args)
        {
            //var X = long.Parse(Console.ReadLine());
            var ABN = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var A = ABN[0]; var B = ABN[1]; var N = ABN[2];

            double x = 0;
            if (B <= N) x = B - 1;
            else x = N;
            Console.WriteLine(Math.Truncate(A * x / B));
        }
    }
}
