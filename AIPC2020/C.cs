using System;
using System.Linq;
using System.Collections.Generic;

namespace AIPC2020
{
    class C
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (long)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var LRd = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            //var a = Console.ReadLine().Split().Select(long.Parse).ToArray();


            for (int i = 1; i <= N; i++)
            {
                var ans = 0;
                for (long x = 1; x <= 100; x++)
                {
                    //double sum = Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2);
                    for (long y = x; y <= 100; y++)
                    {
                        z = 
                        double sum = Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2);
                            if (sum == N) ans++;

                        }
                    }
                    Console.WriteLine(ans);
                }

                Console.WriteLine(ans);
            }



            Console.WriteLine(ans);
        }
    }
}
