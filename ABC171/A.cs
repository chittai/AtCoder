using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC171
{
    class A
    {
        static void Main(string[] args)
        {
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var a = Console.ReadLine();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            if (Char.IsUpper(a[0])) Console.WriteLine("A");
            else Console.WriteLine("a");


        }
    }
}