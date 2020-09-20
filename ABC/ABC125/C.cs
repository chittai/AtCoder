using System;
using System.Linq;

namespace ABC125
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long[] lgcd = new long[N + 1];
            long[] rgcd = new long[N + 1];

            for (int i = 0; i < N; i++)
            {
                lgcd[i + 1] = CalcGCD(lgcd[i], A[i]);
                rgcd[N - i - 1] = CalcGCD(rgcd[N - i], A[N - 1 - i]);
            }

            long res = 0;
            for (int i = 0; i < N; i++)
            {
                res = Math.Max(res, CalcGCD(lgcd[i], rgcd[i + 1]));
            }
            Console.WriteLine(res);

        }
        public static long CalcGCD(long a, long b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }
    }
}
