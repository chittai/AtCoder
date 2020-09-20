using System;
using System.Linq;

namespace ABC152
{
    class E
    {
        static ulong X = 1000000007;
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine());
            ulong[] A = Console.ReadLine().Split().Select(ulong.Parse).ToArray();
            ulong lcm = A[0];
            ulong tes = 0;
            for (ulong i = 1; i < N; i++)
            {
                lcm = CalcLCM(lcm, A[i]);
                tes += lcm / A[i] % X;
            }
            ulong res = 0;
            for (ulong i = 0; i < N; i++)
            {
                res += (lcm / A[i]) % X;
            }

            Console.WriteLine(lcm);
            Console.WriteLine(tes);
            Console.WriteLine(res % X);
        }

        public static ulong CalcGCD(ulong a, ulong b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }

        public static ulong CalcLCM(ulong a, ulong b)
        {
            return a / CalcGCD(a, b) * b % X;
        }

    }
}
