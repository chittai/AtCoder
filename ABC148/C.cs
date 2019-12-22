using System;
using System.Linq;

namespace ABC148
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = input[0];
            int B = input[1];

            long res = CalcLCM(A, B);
            Console.WriteLine(res);
        }

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
}
