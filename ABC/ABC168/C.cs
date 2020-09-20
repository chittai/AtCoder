using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC168
{
    class C
    {
        static void Main(string[] args)
        {
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            var ABHM = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var A = ABHM[0]; var B = ABHM[1]; var H = ABHM[2]; var M = ABHM[3];

            double kakudoA = (360.0 / (12.0 * 60.0)) * (H * 60.0 + M);
            double kakudoB = (360.0 / 60.0) * M;
            double kakudoAB = Math.Abs(kakudoA - kakudoB);
            double kakudo = Math.Min(kakudoAB, 360.0 - kakudoAB);
            Console.WriteLine(Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2) - 2 * A * B * Math.Cos(kakudo * (Math.PI / 180))));
        }
    }
}
