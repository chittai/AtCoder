using System;
using System.Linq;

namespace ABC034
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];
            Console.WriteLine(modCombination(H + W - 2, H - 1, 1000000007));
        }

        ///<summary>
        /// 二分累乗法 O(n) -> O(long n)
        /// 冪が大きいときに計算に使用する
        ///</summary>
        /// <param name="a">べき乗の計算をしたい値</param>
        /// <param name="n">冪</param>
        /// <param name="mod">10^9 + 7 みたいな</param>
        /// <return> a^n (mod mod) </return>
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

        ///<summary>
        /// 逆元の計算。フェルマーの小定理による計算 a^(p-1) ≡ 1 (mod p)
        /// Combination の計算に使用する(多分通常つかわない・・・)
        /// 要は a / b を掛け算の形に変更する
        /// a / b ≡ a * b(逆元) (mod p) みたいな
        ///</summary>
        /// <param name="a">逆元を求めたい値</param>
        /// <param name="mod">10^9 + 7 みたいな</param>
        /// <return> a^n (mod mod) </return>
        public static long modInv(long a, long mod)
        {
            return modPow(a, mod - 2, mod) % mod;
        }

        ///<summary>
        /// mod系の掛け算
        ///</summary>
        public static long modMul(long a, long b, long mod)
        {
            return ((a % mod) * (b % mod)) % mod;
        }

        ///<summary>
        /// mod系の割り算
        ///</summary>
        public static long modDiv(long a, long b, long mod)
        {
            return modMul(a, modInv(b, mod), mod);
        }

        ///<summary>
        /// nCk (mod p)
        ///</summary>
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
