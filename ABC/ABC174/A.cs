using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC174
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var p = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var X = long.Parse(Console.ReadLine());

            if (30 <= X) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}
