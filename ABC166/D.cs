using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC166
{
    class C
    {
        static void Main(string[] args)
        {
            long X = long.Parse(Console.ReadLine());

            bool isBreak = false;
            for (int i = 1; i <= Math.Sqrt(X); i++)
            {
                long x = 0;
                long y = 0;
                if (X % i == 0) { x = i; y = X / i; }
                else continue;

                long z = 1;
                for (int j = 1; j < 5; j++)
                {
                    if (z < X) z *= x;
                    else { isBreak = true; break; }
                }

                z = 1;
                if (isBreak)
                {
                    var res = 0;
                    for (int j = 1; j <= 5; j++)
                    {
                        if (z < X)
                        {
                            z *= x;
                            res *= res;
                        }
                        if (z - res == X) { Console.WriteLine("{0} {1}", z, res); return; }
                        res--;
                    }

                }

            }


        }
    }
}
