using System;
using System.Linq;

namespace AGC028
{
    class A
    {
        static void Main(string[] args)
        {

            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long M = input[1];
            string S = Console.ReadLine();
            string T = Console.ReadLine();

            long gcd = CalcGCD(N, M);
            long n = N / gcd;
            long m = M / gcd;

            for (int i = 0; i < gcd; i++)
            {
                if (S[i * (int)n] != T[i * (int)m])
                {
                    Console.WriteLine("-1");
                    return;
                }

            }
            Console.WriteLine(n * m * gcd);
        }


        public static long CalcGCD(long a, long b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }
    }
}
