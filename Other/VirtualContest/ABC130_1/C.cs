using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC130_1
{
    class C
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var res = (a[0] * a[1]) / 2;
            var res2 = 0;

            if ((a[0] % 2 == 0 && a[0] / 2 == a[2]) && (a[1] % 2 == 0 && a[1] / 2 == a[3])) res2 = 1;
            Console.WriteLine("{0} {1}", res, res2);
        }
    }
}
