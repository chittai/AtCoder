using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC126_1
{
    class C
    {
        static void Main(string[] args)
        {
            var nk = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var n = nk[0];
            var k = nk[1];

            var res = 0.0;
            for (var i = 1.0; i <= n; i++)
            {
                var tmp = i;
                var count = 0.0;
                while (tmp < k)
                {
                    tmp *= 2;
                    count++;
                }
                //Console.WriteLine(count);
                res += (1.0 / n) * Math.Pow(1.0 / 2.0, count);
            }
            Console.WriteLine(res);
        }
    }
}
