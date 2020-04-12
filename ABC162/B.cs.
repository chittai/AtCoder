using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC162
{
    class B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 != 0 && i % 5 != 0) sum += i;
            }

            Console.WriteLine(sum);
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

