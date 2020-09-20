using System;
using System.Linq;
using System.Collections.Generic;

namespace PANASONIC2020
{
    class B
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var H = a[0];
            var W = a[1];

            if (H == 1 || W == 1) { Console.WriteLine(1); return; }

            long res = (long)Math.Ceiling((double)(H * W) / 2);

            Console.WriteLine(res);
        }
    }
}
