using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC175
{
    class Program
    {
        static void Main(string[] args)
        {
            var XKD = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger X = XKD[0]; BigInteger K = XKD[1]; BigInteger D = XKD[2];
            // var A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var N = long.Parse(Console.ReadLine());
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            BigInteger count = X / D; // 移動回数
            if (count < 0) { count = -count; }
            BigInteger dist = X % D; // 0までの距離
            BigInteger rest = K - count; // 残りの試行回数
            //Console.WriteLine(rest);

            if (X == 0)
            {
                if (K % 2 == 0) Console.WriteLine(0);
                else Console.WriteLine(D);
                return;
            }



            if (rest <= 0 && 0 < X) { Console.WriteLine(X - (K * D)); return; }
            if (rest <= 0 && X < 0) { Console.WriteLine(-(X + (K * D))); return; }

            if (rest % 2 == 0) { Console.WriteLine(Math.Abs((long)dist)); return; }

            if (dist <= 0)
            {
                Console.WriteLine(Math.Abs((long)(dist + D)));
            }
            else
            {
                Console.WriteLine(Math.Abs((long)(dist - D)));
            }
        }
    }
}
