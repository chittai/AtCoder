using System;
using System.Linq;
namespace ABC156
{
    class D
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0];
            long a = input[1];
            long b = input[2];
            long mod = 1000000007;

            double ares = 1;
            for (double i = 1; i <= a; i++)
            {
                ares *= (n - i + 1) / i % mod;
            }

            double bres = 1;
            for (double i = 1; i <= b; i++)
            {
                bres *= (n - i + 1) / i % mod;
            }

            long res = 1;
            for (int i = 0; i < n; i++)
            {
                res = (res * 2) % mod;
            }

            Console.WriteLine(res - 1 - (long)ares - (long)bres);

        }
    }
}
