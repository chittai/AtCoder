using System;
using System.Linq;

namespace ABC161
{
    class C
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var n = a[0]; var k = a[1];

            if (n % k == 0) { Console.WriteLine(0); return; }

            long res = 0;
            res = Math.Min(n % k, Math.Abs(n % k - k));
            Console.WriteLine(res);
        }
    }
}
