using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC126_1
{
    class A
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = a[0];
            var K = a[1];
            var s = Console.ReadLine();

            for (int i = 0; i < N; i++)
            {
                if (i == K - 1) Console.Write(s[i].ToString().ToLower());
                else Console.Write(s[i]);
            }
            Console.WriteLine();

        }
    }
}
