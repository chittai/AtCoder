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
            var RCK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var R = RCK[0]; var C = RCK[1]; var K = RCK[2];
            // var A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            var rcv = Enumerable.Repeat(0, (int)K).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var N = long.Parse(Console.ReadLine());
            //var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            var RC = new long[R + 1, C + 1];
            for (int i = 0; i < K; i++)
            {
                if (RC[rcv[i][0], rcv[i][1]] < rcv[i][2]) RC[rcv[i][0], rcv[i][1]] = rcv[i][2];
            }


            //Console.WriteLine("====");

            for (int r = 1; r < R + 1; r++)
            {
                for (int c = 1; c < C + 1; c++)
                {
                    Console.Write(RC[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
