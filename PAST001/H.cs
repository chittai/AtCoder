using System;
using System.Linq;
using System.Collections.Generic;

namespace PAST001
{
    class H
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] C = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long oMin = long.MaxValue;
            long eMin = long.MaxValue;

            long osell = 0;
            long esell = 0;

            for (long i = 0; i < N; i++)
            {
                if (i % 2 == 0) oMin = Math.Min(oMin, C[i]);
                else eMin = Math.Min(eMin, C[i]);
            }
            //Console.WriteLine("{0}, {1}", oMin, eMin);
            //Console.WriteLine("test {0}", (long)Math.Ceiling((double)5 / 2d));

            long Q = long.Parse(Console.ReadLine());
            long res = 0;
            for (long i = 0; i < Q; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (2 < input.Length)
                {
                    long x = input[1] - 1;
                    long a = input[2];

                    if (x % 2 == 0 && a <= C[x] - osell) { C[x] -= a; res += a; }
                    else if (x % 2 == 1 && a <= C[x] - esell) { C[x] -= a; res += a; }

                    if (x % 2 == 0 && C[x] < oMin) { oMin = C[x]; }
                    else if (x % 2 == 1 && C[x] < eMin) { eMin = C[x]; }
                }
                else
                {
                    long a = input[1];
                    if (input[0] == 2) // 2
                    {
                        if (a <= oMin) { oMin -= a; osell += a; res += a * (long)Math.Ceiling((double)N / 2d); }

                    }
                    else // 3
                    {
                        if (a <= oMin && a <= eMin)
                        {
                            oMin -= a;
                            eMin -= a;
                            res += a * N;

                            osell += a;
                            esell += a;
                        }
                    }
                }
                //Console.WriteLine(res);
                //Console.WriteLine("{0}, {1}", oMin, eMin);
            }

            Console.WriteLine(res);
        }
    }
}
