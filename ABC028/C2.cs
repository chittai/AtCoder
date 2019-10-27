using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC028
{
    class C
    {
        static void Main(string[] args)
        {
            int[] alpha = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Max(alpha[4] + alpha[3] + alpha[0], alpha[4] + alpha[2] + alpha[1]));
        }
    }
}
