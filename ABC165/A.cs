using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC165
{
    class A
    {
        static void Main(string[] args)
        {
            var K = long.Parse(Console.ReadLine());
            var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (long i = AB[0]; i <= AB[1]; i++)
            {
                if (i % K == 0) { Console.WriteLine("OK"); return; }
            }
            Console.WriteLine("NG");
        }
    }
}
