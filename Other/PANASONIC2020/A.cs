using System;
using System.Linq;
using System.Collections.Generic;

namespace PANASONIC2020
{
    class A
    {
        static void Main(string[] args)
        {
            //var a = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var a = new int[32] { 1, 1, 1, 2, 1, 2, 1, 5, 2, 2, 1, 5, 1, 2, 1, 14, 1, 5, 1, 5, 2, 2, 1, 15, 2, 2, 5, 4, 1, 4, 1, 51 };
            var K = int.Parse(Console.ReadLine());
            Console.WriteLine(a[K - 1]);
        }
    }
}
