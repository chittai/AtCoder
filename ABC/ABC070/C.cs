using System;

namespace ABC070
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] T = new long[N];
            for (int i = 0; i < N; i++)
            {
                T[i] = long.Parse(Console.ReadLine());
            }

            if (N == 1) { Console.WriteLine(T[0]); return; }

            long lcm = CalcLCM(T[0], T[1]);
            for (int i = 2; i < N; i++)
            {
                lcm = CalcLCM(lcm, T[i]);
            }

            Console.WriteLine(lcm);

        }
        public static long CalcGCD(long a, long b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }

        public static long CalcLCM(long a, long b)
        {
            return a * (b / CalcGCD(a, b));
        }
    }
}
