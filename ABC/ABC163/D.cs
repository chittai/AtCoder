using System;
using System.Linq;

namespace ABC163
{
    class D
    {
        static void Main(string[] args)
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NK[0]; var K = NK[1];

            long res = 0;
            for (long i = K; i <= N + 1; i++)
            {
                var min = i * (i - 1) / 2;
                var max = i * (2 * N - i + 1) / 2;
                var add = max - min + 1;
                res = (res + add) % 1000000007;
            }

            Console.WriteLine(res);
        }
    }
}
