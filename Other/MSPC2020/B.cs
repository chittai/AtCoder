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
            //var X = int.Parse(Console.ReadLine());
            //var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var K = int.Parse(Console.ReadLine());
            var A = ABC[0]; var B = ABC[1]; var C = ABC[2];

            for (int i = 0; i < K; i++)
            {
                if (B <= A)
                {
                    B *= 2;
                }
                else if (C <= B)
                {
                    C *= 2;
                }
                //Console.WriteLine("{0} {1} {2}", A, B, C);
                //if (A < B && B < C) Console.WriteLine("Yes");
            }
            if (A < B && B < C) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
