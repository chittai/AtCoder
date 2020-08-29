
using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace ABC177
{
    class Program
    {
        static void Main(string[] args)
        {
            var DTS = Console.ReadLine().Split().Select(double.Parse).ToArray();
            if (Math.Ceiling(DTS[0] / DTS[2]) <= DTS[1]) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
