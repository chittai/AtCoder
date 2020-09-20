using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC127
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] n = s.Select(x => int.Parse(x)).ToArray();

            int RR = n[0];
            int LL = 1;
            int L, R = 1;

            for (int i = 0; i < n[1]; i++)
            {
                s = Console.ReadLine().Split(' ');
                L = int.Parse(s[0]);
                R = int.Parse(s[1]);

                if (LL > R || RR < L)
                {
                    Console.WriteLine(0);
                    return;
                }

                if (LL < L)
                {
                    LL = L;
                }
                if (R < RR)
                {
                    RR = R;
                }
            }
            Console.WriteLine(RR - LL + 1);
        }
    }
}