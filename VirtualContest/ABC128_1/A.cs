using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC128_1
{
    class A
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine((a[0] * 3 + a[1]) / 2);
        }
    }
}
