using System;
using System.Linq;
using System.Collections.Generic;

namespace PANASONIC2020
{
    class C
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var a = x[0];
            var b = x[1];
            var c = x[2];

            var d = c - a - b;

            if (4 * a * b < d * d && d > 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
