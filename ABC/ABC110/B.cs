using System;
using System.Linq;

namespace ABC110
{
    class B
    {
        static void Main(string[] args)
        {
            var NMXY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var xmax = Console.ReadLine().Split().Select(int.Parse).ToArray().Max();
            var ymin = Console.ReadLine().Split().Select(int.Parse).ToArray().Min();

            if (NMXY[2] < NMXY[3] && Math.Max(NMXY[2], xmax) < Math.Min(NMXY[3], ymin)) Console.WriteLine("No War");
            else Console.WriteLine("War");
        }
    }
}
