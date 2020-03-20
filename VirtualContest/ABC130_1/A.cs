using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC130_1
{
    class A
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (a[0] < a[1]) Console.WriteLine(0);
            else Console.WriteLine(10);
        }
    }
}
