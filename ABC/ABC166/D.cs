using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC166
{
    class D
    {
        static void Main(string[] args)
        {
            long X = long.Parse(Console.ReadLine());
            // A- B = 1 とする。
            // A^5 - B^5 = X の時、まずAとBが取りうる範囲を決める。
            /*
            long ans = 0;
            long A = 1;
            long B = 0;
            while (ans < X)
            {
                if (X < Math.Pow(A, 5) - Math.Pow(B, 5))
                {
                    break;
                }
                A++;
                B++;
            }
            */

            for (long i = -120; i < 120; i++)
            {
                for (long j = -120; j < 120; j++)
                {
                    if (X == Math.Pow(i, 5) - Math.Pow(j, 5))
                    {
                        Console.WriteLine("{0} {1}", i, j); return;
                    }

                }
            }
        }
    }
}
