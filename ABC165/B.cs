using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC165
{
    class B
    {
        static void Main(string[] args)
        {
            var X = long.Parse(Console.ReadLine());
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            double a = 100;
            var count = 0;
            while (a < X)
            {
                a = Math.Truncate(a * 1.01);
                count++;

            }
            Console.WriteLine(count);
        }
    }
}
