using System;
using System.Linq;
using System.Collections.Generic;

namespace MSPC2020
{
    class A
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var LRd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var X = int.Parse(Console.ReadLine());
            //var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (400 <= X && X <= 599) Console.WriteLine("8");
            if (600 <= X && X <= 799) Console.WriteLine("7");
            if (800 <= X && X <= 999) Console.WriteLine("6");
            if (1000 <= X && X <= 1199) Console.WriteLine("5");
            if (1200 <= X && X <= 1399) Console.WriteLine("4");
            if (1400 <= X && X <= 1599) Console.WriteLine("3");
            if (1600 <= X && X <= 1799) Console.WriteLine("2");
            if (1800 <= X && X <= 1999) Console.WriteLine("");

        }
    }
}
