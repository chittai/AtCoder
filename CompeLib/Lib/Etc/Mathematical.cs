/* 数学的処理をまとめる */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Etc
{

    class MOD
    {
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

    class PF
    {
        //prime factorization(素因数分解)
        public static void CalcPF()
        {
            int N = int.Parse(Console.ReadLine());

            int temp;
            int j;
            int[] Res = new int[N + 1];

            for (int i = N; i > 1; i--)
            {
                j = 2;
                temp = i;
                while (j <= N)
                {
                    while (temp % j == 0)
                    {
                        Res[j]++;
                        temp /= j;
                    }
                    j++;
                }
            }
        }
    }

    class GCD
    {
        public static long CalcGCD(long a, long b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }

        public static long CalcLCM(long a, long b)
        {
            return a * b / CalcGCD(a, b);
        }

    }


    class Combination
    {
        // Combination
        static int[,] c;
        public static int[,] init(int x)
        {
            c = new int[x + 5, x + 5];
            c[0, 0] = 1;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0) c[i, j] = c[i - 1, j];
                    else c[i, j] = c[i - 1, j] + c[i - 1, j - 1];
                }
            }
            return c;
        }

        public static int CalcCombination(int n, int k)
        {
            return c[n, k];
        }

    }

    static class Permutation<T>
    {
        private static void Search(List<T[]> perms, Stack<T> stack, T[] a)
        {
            int N = a.Length;
            if (N == 0)
            {
                perms.Add(stack.Reverse().ToArray());
            }
            else
            {
                var b = new T[N - 1];
                Array.Copy(a, 1, b, 0, N - 1);
                for (int i = 0; i < a.Length; ++i)
                {
                    stack.Push(a[i]);
                    Search(perms, stack, b);
                    if (i < b.Length) { b[i] = a[i]; }
                    stack.Pop();
                }
            }
        }
        public static IEnumerable<T[]> All(IEnumerable<T> src)
        {
            var perms = new List<T[]>();
            Search(perms, new Stack<T>(), src.ToArray());
            return perms;
        }
    }
}