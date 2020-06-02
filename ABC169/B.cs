using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC169
{
    class B
    {
        static void Main(string[] args)
        {
            var N = BigInteger.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            if (A.Contains(0)) { Console.WriteLine(0); return; }
            BigInteger res = 1;
            for (int i = 0; i < N; i++)
            {
                res = res * A[i];
                if (1000000000000000000 < res) { Console.WriteLine(-1); return; }
            }
            Console.WriteLine(res);
        }
    }
}
