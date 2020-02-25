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

            long total = modPow(2, n, mod) - 1;
            long ca = modCombination(n, a, mod) % mod;
            long cb = modCombination(n, b, mod) % mod;
            Console.WriteLine((total + mod - (ca + cb) % mod) % mod);
        }

        public static long modPow(long a, long n, long mod)
        {
            long res = 1;
            while (n > 0)
            {
                if ((n & 1) > 0) res = res * a % mod;
                a = a * a % mod;
                n >>= 1;
            }
            return res % mod;
        }
        public static long modInv(long a, long mod)
        {
            return modPow(a, mod - 2, mod) % mod;
        }

        public static long modMul(long a, long b, long mod)
        {
            return ((a % mod) * (b % mod)) % mod;
        }

        public static long modDiv(long a, long b, long mod)
        {
            return modMul(a, modInv(b, mod), mod);
        }

        private static long modCombination(long n, long k, long mod)
        {
            long answer = 1;
            for (long i = n; i > n - k; i--)
            {
                answer = modMul(answer, i, mod);
            }
            for (long i = 1; i <= k; i++)
            {
                answer = modDiv(answer, i, mod);
            }
            return answer;
        }

    }
}
